// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using System.Linq;

    /// <summary>
    /// Defines the properties of an experiment
    /// </summary>
    public partial class ExperimentUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the ExperimentUpdateProperties class.
        /// </summary>
        public ExperimentUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExperimentUpdateProperties class.
        /// </summary>

        /// <param name="description">The description of the intent or details of the Experiment
        /// </param>

        /// <param name="enabledState">The state of the Experiment
        /// Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;</param>
        public ExperimentUpdateProperties(string description = default(string), string enabledState = default(string))

        {
            this.Description = description;
            this.EnabledState = enabledState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the description of the intent or details of the Experiment
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets the state of the Experiment Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabledState")]
        public string EnabledState {get; set; }
    }
}