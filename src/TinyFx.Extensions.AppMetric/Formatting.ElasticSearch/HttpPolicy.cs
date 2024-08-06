﻿// <copyright file="HttpPolicy.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

using System;
using TinyFx.Extensions.AppMetric.Formatting.ElasticSearch.Client;

namespace TinyFx.Extensions.AppMetric.Formatting.ElasticSearch
{
    public class HttpPolicy
    {
        public HttpPolicy()
        {
            FailuresBeforeBackoff = Constants.DefaultFailuresBeforeBackoff;
            BackoffPeriod = Constants.DefaultBackoffPeriod;
            Timeout = Constants.DefaultTimeout;
        }

        public TimeSpan BackoffPeriod { get; set; }

        public int FailuresBeforeBackoff { get; set; }

        public TimeSpan Timeout { get; set; }
    }
}