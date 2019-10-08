using System;
using SODA.Utilities;
using System.Security.Permissions;

namespace SODA

{
    /// <summary>
    /// A class for accessing the revision object.
    /// </summary>
    public class Revision
    {
        /// <summary>
        /// The result of a revision being created.
        /// </summary>
        Result result;

        /// <summary>
        /// A class for handling revisions.
        /// </summary>
        public Revision(Result result)
        {
            this.result = result;
            Console.WriteLine(String.Format("Revision number {0} created", result.Resource["revision_seq"]));

        }

        public long GetRevisionNumber()
        {
            return this.result.Resource["revision_seq"];
        }

        public string getRevisionLink()
        {
          return this.result.Links["self"];
        }

        /// <summary>
        /// A class for interacting with Socrata Data Portals using the Socrata Open Data API.
        /// </summary>
        public string GetSourceEndpoint()
        {
            return this.result.Links["create_source"];
        }

        /// <summary>
        /// A class for interacting with Socrata Data Portals using the Socrata Open Data API.
        /// </summary>
        public string GetApplyEndpoint()
        {
            return this.result.Links["apply"];
        }

    }
}