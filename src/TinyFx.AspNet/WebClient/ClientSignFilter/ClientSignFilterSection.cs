﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.AspNet;
using TinyFx.Collections;
using TinyFx.Logging;
using TinyFx.Reflection;

namespace TinyFx.Configuration
{
    public class ClientSignFilterSection : ConfigSection
    {
        public override string SectionName => "ClientSignFilter";

        public string DefaultFilterName { get; set; }
        public string FiltersProvider { get; set; }
        public Dictionary<string, ClientSignFilterElement> Filters { get; set; } = new();
        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);

            // Filters
            Filters ??= new();
            Filters.ForEach(item => item.Value.Name = item.Key);

            // FiltersProvider
            if (!string.IsNullOrEmpty(FiltersProvider))
            {
                var provider = ReflectionUtil.CreateInstance(FiltersProvider) as IClientSignFiltersProvider;
                if (provider == null)
                    throw new Exception($"配置中{SectionName}:FiltersProvider不存在或未实现{nameof(IClientSignFiltersProvider)}: {FiltersProvider}");
                var list = provider.Build();
                foreach (var item in list)
                {
                    if (string.IsNullOrEmpty(item.Name))
                        throw new Exception($"配置中{SectionName}:FiltersProvider实现返回的集合name不能为空。provider: {FiltersProvider}");
                    if (Filters.ContainsKey(item.Name))
                        LogUtil.Warning($"配置中{SectionName}:FiltersProvider提供的与原有的配置name重复。provider: {FiltersProvider} name: {item.Name}");
                    else
                        Filters.Add(item.Name, item);
                }
            }

            // DefaultFilterName
            if (string.IsNullOrEmpty(DefaultFilterName))
            {
                if (Filters.Count > 1)
                    throw new Exception($"{SectionName}:DefaultFilterName为空但Filters不唯一");
                DefaultFilterName = Filters.First().Key;
            }
            else
            {
                if (!Filters.ContainsKey(DefaultFilterName))
                    throw new Exception($"{SectionName}:Filters不存在DefaultFilterName: {DefaultFilterName}");
            }
        }
    }
    public class ClientSignFilterElement
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string HeaderName { get; set; }
        public string KeySeed { get; set; }
        public string KeyIndexes { get; set; }
        private int[] _keyIndexes;
        public int[] GetKeyIndexes()
        {
            if (_keyIndexes == null)
            {
                if (string.IsNullOrEmpty(KeyIndexes))
                    throw new Exception($"配置AccessSignFilter:Filters:{Name}:KeyIndexes不能为空");
                _keyIndexes = KeyIndexes.Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim().ToInt32()).ToArray();
            }
            return _keyIndexes;
        }
    }
}
