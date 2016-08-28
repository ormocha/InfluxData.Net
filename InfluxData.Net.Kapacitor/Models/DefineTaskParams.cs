﻿using System.Collections.Generic;
using InfluxData.Net.InfluxDb.Enums;
using InfluxData.Net.Kapacitor.Constants;

namespace InfluxData.Net.Kapacitor.Models
{
    /// <summary>
<<<<<<< HEAD
    /// Task definition object. Used for creating tasks in Kapacitor. using a given tick script
=======
    /// Task definition object. Used for creating tasks in Kapacitor. Uses a tick script.
>>>>>>> upstream/master
    /// </summary>
    public class DefineTaskParams : BaseTaskParams
    {
        /// <summary>
        /// Task type - stream, batch..
        /// </summary>
        public TaskType TaskType { get; set; }

        /// <summary>
        /// Tick script to save.
        /// </summary>
        public string TickScript { get; set; }
<<<<<<< HEAD

        internal override Dictionary<string, object> ToJsonDictionary()
        {
            var jsonDictionary = base.ToJsonDictionary();
            jsonDictionary.Add(BodyParams.Type, TaskType.ToString().ToLower());
            jsonDictionary.Add(BodyParams.Script, TickScript);
            return jsonDictionary;
        }
    }    
=======
    }
>>>>>>> upstream/master
}
