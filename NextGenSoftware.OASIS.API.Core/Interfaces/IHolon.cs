﻿using System;
using System.Collections.Generic;
using NextGenSoftware.OASIS.API.Core.Enums;
using NextGenSoftware.OASIS.API.Core.Helpers;
using NextGenSoftware.OASIS.API.Core.Holons;

namespace NextGenSoftware.OASIS.API.Core.Interfaces
{
    public interface IHolon
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        Dictionary<ProviderType, string> ProviderKey { get; set; }
        Dictionary<ProviderType, Dictionary<string, string>> ProviderMetaData { get; set; } 
        Dictionary<string, string> MetaData { get; set; } 
        HolonType HolonType { get; set; }
        ICelestialBody ParentCelestialBody { get; set; }
        IZome ParentZome { get; set; }
        IHolon Parent { get; set; }
        IEnumerable<IHolon> Children { get; set; }
        Guid CreatedByAvatarId { get; set; }
        Avatar CreatedByAvatar { get; set; }
        DateTime CreatedDate { get; set; }
        Guid ModifiedByAvatarId { get; set; }
        Avatar ModifiedByAvatar { get; set; }
        DateTime ModifiedDate { get; set; }
        Guid DeletedByAvatarId { get; set; }
        Avatar DeletedByAvatar { get; set; }
        DateTime DeletedDate { get; set; }
        bool IsActive { get; set; }
        int Version { get; set; }
        EnumValue<ProviderType> CreatedProviderType { get; set; }
        public List<INode> Nodes { get; set; }
    }
}
