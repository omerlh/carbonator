﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Crypton.Carbonator.Config
{
    /// <summary>
    /// Defines an entry for a performance counter that will be sampled and reported
    /// </summary>
    public class PerformanceCounterElement : ConfigurationElement
    {

        /// <summary>
        /// Gets or sets the Carbon namespace path for this reported counter. Also acts as unique key for configuration
        /// </summary>
        [ConfigurationProperty("path", IsKey = true, IsRequired = true)]
        public string Path
        {
            get { return (string)base["path"]; }
            set { base["path"] = value; }
        }

        /// <summary>
        /// Gets or sets the performance counter category name
        /// </summary>
        [ConfigurationProperty("category", IsRequired = true)]
        public string CategoryName
        {
            get { return (string)base["category"]; }
            set { base["category"] = value; }
        }

        /// <summary>
        /// Gets or sets the performance counter name
        /// </summary>
        [ConfigurationProperty("counter", IsRequired = true)]
        public string CounterName
        {
            get { return (string)base["counter"]; }
            set { base["counter"] = value; }
        }

        /// <summary>
        /// Gets or sets the performance counter instance name, may be required for some counters
        /// </summary>
        [ConfigurationProperty("instance", IsRequired = false)]
        public string InstanceName
        {
            get { return (string)base["instance"]; }
            set { base["instance"] = value; }
        }

    }
}
