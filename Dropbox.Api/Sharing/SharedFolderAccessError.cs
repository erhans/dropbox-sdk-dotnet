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
    /// <para>There is an error accessing the shared folder.</para>
    /// </summary>
    public class SharedFolderAccessError : enc.IEncodable<SharedFolderAccessError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderAccessError" />
        /// class.</para>
        /// </summary>
        public SharedFolderAccessError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidId</para>
        /// </summary>
        public bool IsInvalidId
        {
            get
            {
                return this is InvalidId;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidId, or <c>null</c>.</para>
        /// </summary>
        public InvalidId AsInvalidId
        {
            get
            {
                return this as InvalidId;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotMember</para>
        /// </summary>
        public bool IsNotMember
        {
            get
            {
                return this is NotMember;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotMember, or <c>null</c>.</para>
        /// </summary>
        public NotMember AsNotMember
        {
            get
            {
                return this as NotMember;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is HasLeft</para>
        /// </summary>
        public bool IsHasLeft
        {
            get
            {
                return this is HasLeft;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a HasLeft, or <c>null</c>.</para>
        /// </summary>
        public HasLeft AsHasLeft
        {
            get
            {
                return this as HasLeft;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RequireOwner</para>
        /// </summary>
        public bool IsRequireOwner
        {
            get
            {
                return this is RequireOwner;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RequireOwner, or <c>null</c>.</para>
        /// </summary>
        public RequireOwner AsRequireOwner
        {
            get
            {
                return this as RequireOwner;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is IsRoot</para>
        /// </summary>
        public bool IsIsRoot
        {
            get
            {
                return this is IsRoot;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a IsRoot, or <c>null</c>.</para>
        /// </summary>
        public IsRoot AsIsRoot
        {
            get
            {
                return this as IsRoot;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is IsTeamSharedFolder</para>
        /// </summary>
        public bool IsIsTeamSharedFolder
        {
            get
            {
                return this is IsTeamSharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a IsTeamSharedFolder, or <c>null</c>.</para>
        /// </summary>
        public IsTeamSharedFolder AsIsTeamSharedFolder
        {
            get
            {
                return this as IsTeamSharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is IsAppFolder</para>
        /// </summary>
        public bool IsIsAppFolder
        {
            get
            {
                return this is IsAppFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a IsAppFolder, or <c>null</c>.</para>
        /// </summary>
        public IsAppFolder AsIsAppFolder
        {
            get
            {
                return this as IsAppFolder;
            }
        }

        #region IEncodable<SharedFolderAccessError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<SharedFolderAccessError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsInvalidId)
            {
                ((enc.IEncodable<InvalidId>)this).Encode(encoder);
            }
            else if (this.IsNotMember)
            {
                ((enc.IEncodable<NotMember>)this).Encode(encoder);
            }
            else if (this.IsHasLeft)
            {
                ((enc.IEncodable<HasLeft>)this).Encode(encoder);
            }
            else if (this.IsRequireOwner)
            {
                ((enc.IEncodable<RequireOwner>)this).Encode(encoder);
            }
            else if (this.IsIsRoot)
            {
                ((enc.IEncodable<IsRoot>)this).Encode(encoder);
            }
            else if (this.IsIsTeamSharedFolder)
            {
                ((enc.IEncodable<IsTeamSharedFolder>)this).Encode(encoder);
            }
            else if (this.IsIsAppFolder)
            {
                ((enc.IEncodable<IsAppFolder>)this).Encode(encoder);
            }
            else
            {
                throw new sys.InvalidOperationException();
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        SharedFolderAccessError enc.IEncodable<SharedFolderAccessError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "invalid_id":
                return InvalidId.Instance;
            case "not_member":
                return NotMember.Instance;
            case "has_left":
                return HasLeft.Instance;
            case "require_owner":
                return RequireOwner.Instance;
            case "is_root":
                return IsRoot.Instance;
            case "is_team_shared_folder":
                return IsTeamSharedFolder.Instance;
            case "is_app_folder":
                return IsAppFolder.Instance;
            default:
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        /// <summary>
        /// <para>This shared folder ID is invalid.</para>
        /// </summary>
        public sealed class InvalidId : SharedFolderAccessError, enc.IEncodable<InvalidId>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidId" /> class.</para>
            /// </summary>
            private InvalidId()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidId</para>
            /// </summary>
            public static readonly InvalidId Instance = new InvalidId();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<InvalidId>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "invalid_id");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            InvalidId enc.IEncodable<InvalidId>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The user is not a member of the shared folder thus cannot access it.</para>
        /// </summary>
        public sealed class NotMember : SharedFolderAccessError, enc.IEncodable<NotMember>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotMember" /> class.</para>
            /// </summary>
            private NotMember()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotMember</para>
            /// </summary>
            public static readonly NotMember Instance = new NotMember();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<NotMember>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "not_member");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            NotMember enc.IEncodable<NotMember>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The user has left the shared folder already thus is no longer able to access
        /// it.</para>
        /// </summary>
        public sealed class HasLeft : SharedFolderAccessError, enc.IEncodable<HasLeft>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="HasLeft" /> class.</para>
            /// </summary>
            private HasLeft()
            {
            }

            /// <summary>
            /// <para>A singleton instance of HasLeft</para>
            /// </summary>
            public static readonly HasLeft Instance = new HasLeft();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<HasLeft>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "has_left");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            HasLeft enc.IEncodable<HasLeft>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The user needs to be the owner to access the shared folder.</para>
        /// </summary>
        public sealed class RequireOwner : SharedFolderAccessError, enc.IEncodable<RequireOwner>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RequireOwner" />
            /// class.</para>
            /// </summary>
            private RequireOwner()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RequireOwner</para>
            /// </summary>
            public static readonly RequireOwner Instance = new RequireOwner();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<RequireOwner>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "require_owner");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            RequireOwner enc.IEncodable<RequireOwner>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The folder is a root folder and cannot be shared.</para>
        /// </summary>
        public sealed class IsRoot : SharedFolderAccessError, enc.IEncodable<IsRoot>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IsRoot" /> class.</para>
            /// </summary>
            private IsRoot()
            {
            }

            /// <summary>
            /// <para>A singleton instance of IsRoot</para>
            /// </summary>
            public static readonly IsRoot Instance = new IsRoot();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<IsRoot>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "is_root");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            IsRoot enc.IEncodable<IsRoot>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The folder is a team shared folder and the user cannot access it.</para>
        /// </summary>
        public sealed class IsTeamSharedFolder : SharedFolderAccessError, enc.IEncodable<IsTeamSharedFolder>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IsTeamSharedFolder" />
            /// class.</para>
            /// </summary>
            private IsTeamSharedFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of IsTeamSharedFolder</para>
            /// </summary>
            public static readonly IsTeamSharedFolder Instance = new IsTeamSharedFolder();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<IsTeamSharedFolder>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "is_team_shared_folder");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            IsTeamSharedFolder enc.IEncodable<IsTeamSharedFolder>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The folder is an app folder and cannot be shared.</para>
        /// </summary>
        public sealed class IsAppFolder : SharedFolderAccessError, enc.IEncodable<IsAppFolder>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="IsAppFolder" />
            /// class.</para>
            /// </summary>
            private IsAppFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of IsAppFolder</para>
            /// </summary>
            public static readonly IsAppFolder Instance = new IsAppFolder();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<IsAppFolder>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "is_app_folder");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            IsAppFolder enc.IEncodable<IsAppFolder>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
