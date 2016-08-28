using System;
using System.Collections.Generic;
using InfluxData.Net.InfluxDb.Enums;
using InfluxData.Net.Kapacitor.Constants;
<<<<<<< HEAD
=======
using Newtonsoft.Json;
>>>>>>> upstream/master

namespace InfluxData.Net.Kapacitor.Models
{
    /// <summary>
<<<<<<< HEAD
    /// abstract Task definition object. Used for creating tasks in Kapacitor.
=======
    /// Base Task definition object. Used for creating tasks in Kapacitor.
>>>>>>> upstream/master
    /// </summary>
    public abstract class BaseTaskParams
    {
        /// <summary>
        /// Task id (Name in older versions).
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [Obsolete("Please use TaskId property instead")]
        public string TaskName
        {
<<<<<<< HEAD
            get { return this.TaskId; }
            set { this.TaskId = value; }
        }        
=======
            get
            {
                return this.TaskId;
            }
            set {
                this.TaskId = value;
            }
        }
>>>>>>> upstream/master

        /// <summary>
        /// Database name / retention policy params.
        /// </summary>
        public DBRPsParams DBRPsParams { get; set; }

        /// <summary>
<<<<<<< HEAD
        /// Generates a json mapping dictionary from type to value
        /// </summary>
        /// <returns></returns>
        internal virtual Dictionary<string, object> ToJsonDictionary()
        {
            var jsonDictionary = new Dictionary<string, object>
            {
                {BodyParams.Id, TaskId},               
                {
                    BodyParams.Dbrps, new List<IDictionary<string, string>>
                    {
                        new Dictionary<string, string>()
                        {
                            {BodyParams.Db, DBRPsParams.DbName},
                            {BodyParams.RetentionPolicy, DBRPsParams.RetentionPolicy}
                        }
                    }
                }
            };
            return jsonDictionary;
        }
=======
        /// Variable dictionary that will be passed to create this task.
        /// </summary>
        public Dictionary<string, TaskVar> TaskVars { get; set; }
>>>>>>> upstream/master
    }

    /// <summary>
    /// Database name / retention policy params object. Used as a part of DefineTaskParams.
    /// </summary>
    public class DBRPsParams
    {
        /// <summary>
        /// Database name.
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// Retention policy.
        /// </summary>
        public string RetentionPolicy { get; set; }
    }
<<<<<<< HEAD
=======

    /// <summary>
    /// A task variable for overwriting any defined vars in the TICKscript.
    /// </summary>
    public class TaskVar
    {
        /// <summary>
        /// The type of the variable (lambda, string, etc..).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value for the task.
        /// </summary>
        public string Value { get; set; }
    }
>>>>>>> upstream/master
}