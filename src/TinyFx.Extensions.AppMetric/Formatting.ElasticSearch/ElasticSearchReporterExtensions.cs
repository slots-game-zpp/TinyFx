﻿// <copyright file="ElasticSearchReporterExtensions.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using System;
using App.Metrics.Abstractions.Filtering;
using App.Metrics.Reporting.Abstractions;
using TinyFx.Extensions.AppMetric.Formatting.ElasticSearch.Client;

// ReSharper disable CheckNamespace
namespace TinyFx.Extensions.AppMetric.Formatting.ElasticSearch
// ReSharper restore CheckNamespace
{
    public static class ElasticSearchReporterExtensions
    {
        public static IReportFactory AddElasticSearch(
            this IReportFactory factory,
            ElasticSearchReporterSettings settings,
            IFilterMetrics filter = null)
        {
            factory.AddProvider(new ElasticSearchReporterProvider(settings, filter));
            return factory;
        }

        public static IReportFactory AddElasticSearch(
            this IReportFactory factory,
            Uri address,
            string indexName,
            IFilterMetrics filter = null)
        {
            var settings = new ElasticSearchReporterSettings
            {
                ElasticSearchSettings = new ElasticSearchSettings(address, indexName)
            };

            factory.AddElasticSearch(settings, filter);
            return factory;
        }
    }
}