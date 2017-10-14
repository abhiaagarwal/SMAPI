namespace StardewModdingAPI.Framework.Models
{
    /// <summary>Indicates how SMAPI should treat a mod.</summary>
    internal enum ModStatus
    {
        /// <summary>Don't override the status.</summary>
        None,

        /// <summary>The mod is obsolete and shouldn't be used, regardless of version.</summary>
        Obsolete,

        /// <summary>Assume the mod is not compatible, even if SMAPI doesn't detect any incompatible code.</summary>
        AssumeBroken,

        /// <summary>Assume the mod is compatible, even if SMAPI detects incompatible code.</summary>
        AssumeCompatible
    }
}
