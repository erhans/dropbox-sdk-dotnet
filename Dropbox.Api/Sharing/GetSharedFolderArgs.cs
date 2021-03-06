// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The get shared folder args object</para>
    /// </summary>
    public sealed class GetSharedFolderArgs : enc.IEncodable<GetSharedFolderArgs>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetSharedFolderArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="id">The ID for the shared folder.</param>
        /// <param name="includeMembership">If include user and group membership information in
        /// the response.</param>
        public GetSharedFolderArgs(string id,
                                   bool includeMembership = true)
        {
            if (id == null)
            {
                throw new sys.ArgumentNullException("id");
            }
            else if (!re.Regex.IsMatch(id, @"[-_0-9a-zA-Z]+"))
            {
                throw new sys.ArgumentOutOfRangeException("id");
            }

            this.Id = id;
            this.IncludeMembership = includeMembership;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetSharedFolderArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetSharedFolderArgs()
        {
            this.IncludeMembership = true;
        }

        /// <summary>
        /// <para>The ID for the shared folder.</para>
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// <para>If include user and group membership information in the response.</para>
        /// </summary>
        public bool IncludeMembership { get; private set; }

        #region IEncodable<GetSharedFolderArgs> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<GetSharedFolderArgs>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("id", this.Id);
                obj.AddField<bool>("include_membership", this.IncludeMembership);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        GetSharedFolderArgs enc.IEncodable<GetSharedFolderArgs>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Id = obj.GetField<string>("id");
                if (obj.HasField("include_membership"))
                {
                    this.IncludeMembership = obj.GetField<bool>("include_membership");
                }
            }

            return this;
        }

        #endregion
    }
}
