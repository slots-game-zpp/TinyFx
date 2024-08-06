﻿namespace Nacos.Naming.Dtos
{
    using Nacos.Common;
    using Nacos.Utils;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ServiceInfo
    {
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("groupName")]
        public string GroupName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("cacheMillis")]
        public long CacheMillis { get; set; } = 1000L;

        [System.Text.Json.Serialization.JsonPropertyName("lastRefTime")]
        public long LastRefTime { get; set; } = 0L;

        [System.Text.Json.Serialization.JsonPropertyName("checksum")]
        public string Checksum { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("hosts")]
        public List<Instance> Hosts { get; set; } = new List<Instance>();

        [System.Text.Json.Serialization.JsonPropertyName("metallIPsadata")]
        public bool AllIPs { get; set; } = false;

        [System.Text.Json.Serialization.JsonPropertyName("clusters")]
        public string Clusters { get; set; }

        public ServiceInfo()
        {
        }

        public ServiceInfo(string key)
        {
            int maxIndex = 2;
            int clusterIndex = 2;
            int serviceNameIndex = 1;
            int groupIndex = 0;

            key = key.ToDecode();

            var keys = key.SplitByString(Constants.SERVICE_INFO_SPLITER);
            if (keys.Length >= maxIndex + 1)
            {
                GroupName = keys[groupIndex];
                Name = keys[serviceNameIndex];
                Clusters = keys[clusterIndex];
            }
            else if (keys.Length == maxIndex)
            {
                GroupName = keys[groupIndex];
                Name = keys[serviceNameIndex];
            }
            else
            {
                // defensive programming
                throw new ArgumentException("Cann't parse out 'groupName',but it must not be null!");
            }
        }

        public ServiceInfo(string serviceName, string clusters)
        {
            Name = serviceName;
            Clusters = clusters;
        }

        public int IpCount() => Hosts.Count;

        public string GetKey() => GetKey(GetGroupedServiceName(), Clusters);

        public static string GetKey(string name, string clusters)
            => !string.IsNullOrEmpty(clusters) ? name + Constants.SERVICE_INFO_SPLITER + clusters : name;


        [System.Text.Json.Serialization.JsonIgnore]
        public string JsonFromServer { get; set; }

        public string GetKeyEncoded() => GetKey(GetGroupedServiceName(), Clusters).ToEncoded();

        public bool Validate()
        {
            if (AllIPs) return true;

            return Hosts.Any(h => h.Healthy && h.Weight > 0);
        }

        private string GetGroupedServiceName()
            => !string.IsNullOrWhiteSpace(GroupName) && Name.IndexOf(Constants.SERVICE_INFO_SPLITER) == -1
                ? GroupName + Constants.SERVICE_INFO_SPLITER + Name
                : Name;

        public static ServiceInfo FromKey(string key)
        {
            var serviceInfo = new ServiceInfo();
            int maxSegCount = 3;
            string[] segs = key.SplitByString(Constants.SERVICE_INFO_SPLITER);
            if (segs.Length == maxSegCount - 1)
            {
                serviceInfo.GroupName = segs[0];
                serviceInfo.Name = segs[1];
            }
            else if (segs.Length == maxSegCount)
            {
                serviceInfo.GroupName = segs[0];
                serviceInfo.Name = segs[1];
                serviceInfo.Clusters = segs[2];
            }

            return serviceInfo;
        }

        public override string ToString() => GetKey();
    }
}
