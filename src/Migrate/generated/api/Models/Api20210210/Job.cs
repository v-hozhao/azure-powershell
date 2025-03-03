namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Job details.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Migrate.DoNotFormat]
    public partial class Job :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJob,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.Resource();

        /// <summary>The activity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).ActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).ActivityId = value ?? null; }

        /// <summary>The Allowed action the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string[] AllowedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).AllowedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).AllowedAction = value ?? null /* arrayOf */; }

        /// <summary>
        /// The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow
        /// object details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails CustomDetailAffectedObjectDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).CustomDetailAffectedObjectDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).CustomDetailAffectedObjectDetail = value ?? null /* model class */; }

        /// <summary>Gets the type of job details (see JobDetailsTypes enum for possible values).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string CustomDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).CustomDetailInstanceType; }

        /// <summary>The end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>The errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails[] Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).Error = value ?? null /* arrayOf */; }

        /// <summary>The DisplayName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).FriendlyName = value ?? null; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; }

        /// <summary>Resource Location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for CustomDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobInternal.CustomDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).CustomDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).CustomDetail = value; }

        /// <summary>Internal Acessors for CustomDetailInstanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobInternal.CustomDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).CustomDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).CustomDetailInstanceType = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.JobPropertiesAutoGenerated()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGenerated _property;

        /// <summary>The custom data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGenerated Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.JobPropertiesAutoGenerated()); set => this._property = value; }

        /// <summary>The ScenarioName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).ScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).ScenarioName = value ?? null; }

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>
        /// The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or
        /// Other.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).State = value ?? null; }

        /// <summary>
        /// The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string StateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).StateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).StateDescription = value ?? null; }

        /// <summary>
        /// The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string TargetInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).TargetInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).TargetInstanceType = value ?? null; }

        /// <summary>The affected Object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string TargetObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).TargetObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).TargetObjectId = value ?? null; }

        /// <summary>The name of the affected object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string TargetObjectName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).TargetObjectName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).TargetObjectName = value ?? null; }

        /// <summary>The tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] Task { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).Task; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGeneratedInternal)Property).Task = value ?? null /* arrayOf */; }

        /// <summary>Resource Type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Job" /> instance.</summary>
        public Job()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Job details.
    public partial interface IJob :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResource
    {
        /// <summary>The activity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The activity id.",
        SerializedName = @"activityId",
        PossibleTypes = new [] { typeof(string) })]
        string ActivityId { get; set; }
        /// <summary>The Allowed action the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Allowed action the job.",
        SerializedName = @"allowedActions",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedAction { get; set; }
        /// <summary>
        /// The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow
        /// object details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow object details.",
        SerializedName = @"affectedObjectDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails CustomDetailAffectedObjectDetail { get; set; }
        /// <summary>Gets the type of job details (see JobDetailsTypes enum for possible values).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the type of job details (see JobDetailsTypes enum for possible values).",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomDetailInstanceType { get;  }
        /// <summary>The end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end time.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The errors.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails[] Error { get; set; }
        /// <summary>The DisplayName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DisplayName.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>The ScenarioName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ScenarioName.",
        SerializedName = @"scenarioName",
        PossibleTypes = new [] { typeof(string) })]
        string ScenarioName { get; set; }
        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>
        /// The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or
        /// Other.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or Other.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>
        /// The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded, CompletedWithInformation or Skipped.",
        SerializedName = @"stateDescription",
        PossibleTypes = new [] { typeof(string) })]
        string StateDescription { get; set; }
        /// <summary>
        /// The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.",
        SerializedName = @"targetInstanceType",
        PossibleTypes = new [] { typeof(string) })]
        string TargetInstanceType { get; set; }
        /// <summary>The affected Object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The affected Object Id.",
        SerializedName = @"targetObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetObjectId { get; set; }
        /// <summary>The name of the affected object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the affected object.",
        SerializedName = @"targetObjectName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetObjectName { get; set; }
        /// <summary>The tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tasks.",
        SerializedName = @"tasks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] Task { get; set; }

    }
    /// Job details.
    internal partial interface IJobInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IResourceInternal
    {
        /// <summary>The activity id.</summary>
        string ActivityId { get; set; }
        /// <summary>The Allowed action the job.</summary>
        string[] AllowedAction { get; set; }
        /// <summary>The custom job details like test failover job details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetails CustomDetail { get; set; }
        /// <summary>
        /// The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow
        /// object details.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobDetailsAffectedObjectDetails CustomDetailAffectedObjectDetail { get; set; }
        /// <summary>Gets the type of job details (see JobDetailsTypes enum for possible values).</summary>
        string CustomDetailInstanceType { get; set; }
        /// <summary>The end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The errors.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobErrorDetails[] Error { get; set; }
        /// <summary>The DisplayName.</summary>
        string FriendlyName { get; set; }
        /// <summary>The custom data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IJobPropertiesAutoGenerated Property { get; set; }
        /// <summary>The ScenarioName.</summary>
        string ScenarioName { get; set; }
        /// <summary>The start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>
        /// The status of the Job. It is one of these values - NotStarted, InProgress, Succeeded, Failed, Cancelled, Suspended or
        /// Other.
        /// </summary>
        string State { get; set; }
        /// <summary>
        /// The description of the state of the Job. For e.g. - For Succeeded state, description can be Completed, PartiallySucceeded,
        /// CompletedWithInformation or Skipped.
        /// </summary>
        string StateDescription { get; set; }
        /// <summary>
        /// The type of the affected object which is of Microsoft.Azure.SiteRecovery.V2015_11_10.AffectedObjectType class.
        /// </summary>
        string TargetInstanceType { get; set; }
        /// <summary>The affected Object Id.</summary>
        string TargetObjectId { get; set; }
        /// <summary>The name of the affected object.</summary>
        string TargetObjectName { get; set; }
        /// <summary>The tasks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IAsrTask[] Task { get; set; }

    }
}