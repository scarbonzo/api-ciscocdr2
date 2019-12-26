using Microsoft.EntityFrameworkCore;

namespace api_ciscocdr2.Models
{
    public partial class CallAnalyzerContext : DbContext
    {
        public CallAnalyzerContext()
        {
        }

        public CallAnalyzerContext(DbContextOptions<CallAnalyzerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calls> Calls { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Calls>(entity =>
            {
                entity.HasKey(e => e.Pkid)
                    .HasName("PK_dbo.Calls");

                entity.HasIndex(e => e.CallingPartyNumber)
                    .HasName("IX_callingPartyNumber");

                entity.HasIndex(e => e.DestCauseValue)
                    .HasName("IX_destCause_value");

                entity.HasIndex(e => e.DestDeviceName)
                    .HasName("IX_destDeviceName");

                entity.HasIndex(e => e.FinalCalledPartyNumber)
                    .HasName("IX_finalCalledPartyNumber");

                entity.HasIndex(e => e.OrigCauseValue)
                    .HasName("IX_origCause_value");

                entity.HasIndex(e => e.OrigDeviceName)
                    .HasName("IX_origDeviceName");

                entity.HasIndex(e => e.OriginalCalledPartyNumber)
                    .HasName("IX_originalCalledPartyNumber");

                entity.HasIndex(e => new { e.CallingPartyNumber, e.OriginalCalledPartyNumber, e.FinalCalledPartyNumber, e.DateTimeDisconnect })
                    .HasName("Unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.Pkid, e.Year, e.Month, e.Day, e.Hour, e.Minute, e.DayOfWeek, e.CdrRecordType, e.GlobalCallIdCallManagerId, e.GlobalCallIdCallId, e.OrigLegCallIdentifier, e.DateTimeOrigination, e.OrigNodeId, e.OrigSpan, e.OrigIpAddr, e.CallingPartyNumber, e.CallingPartyUnicodeLoginUserId, e.OrigCauseLocation, e.OrigCauseValue, e.OrigPrecedenceLevel, e.OrigMediaTransportAddressIp, e.OrigMediaTransportAddressPort, e.OrigMediaCapPayloadCapability, e.OrigMediaCapMaxFramesPerPacket, e.OrigMediaCapG723BitRate, e.OrigVideoCapCodec, e.OrigVideoCapBandwidth, e.OrigVideoCapResolution, e.OrigVideoTransportAddressIp, e.OrigVideoTransportAddressPort, e.OrigRsvpaudioStat, e.OrigRsvpvideoStat, e.DestLegIdentifier, e.DestNodeId, e.DestSpan, e.DestIpAddr, e.OriginalCalledPartyNumber, e.FinalCalledPartyNumber, e.FinalCalledPartyUnicodeLoginUserId, e.DestCauseLocation, e.DestCauseValue, e.DestPrecedenceLevel, e.DestMediaTransportAddressIp, e.DestMediaTransportAddressPort, e.DestMediaCapPayloadCapability, e.DestMediaCapMaxFramesPerPacket, e.DestMediaCapG723BitRate, e.DestVideoCapCodec, e.DestVideoCapBandwidth, e.DestVideoCapResolution, e.DestVideoTransportAddressIp, e.DestVideoTransportAddressPort, e.DestRsvpaudioStat, e.DestRsvpvideoStat, e.DateTimeConnect, e.LastRedirectDn, e.OriginalCalledPartyNumberPartition, e.CallingPartyNumberPartition, e.FinalCalledPartyNumberPartition, e.LastRedirectDnPartition, e.Duration, e.OrigDeviceName, e.DestDeviceName, e.OrigCallTerminationOnBehalfOf, e.DestCallTerminationOnBehalfOf, e.OrigCalledPartyRedirectOnBehalfOf, e.LastRedirectRedirectOnBehalfOf, e.OrigCalledPartyRedirectReason, e.LastRedirectRedirectReason, e.DestConversationId, e.GlobalCallIdClusterId, e.JoinOnBehalfOf, e.Comment, e.AuthCodeDescription, e.AuthorizationLevel, e.ClientMatterCode, e.OrigDtmfmethod, e.DestDtmfmethod, e.CallSecuredStatus, e.OrigConversationId, e.OrigMediaCapBandwidth, e.DestMediaCapBandwidth, e.AuthorizationCodeValue, e.OutpulsedCallingPartyNumber, e.OutpulsedCalledPartyNumber, e.OrigIpv4v6Addr, e.DestIpv4v6Addr, e.OrigVideoCapCodecChannel2, e.OrigVideoCapBandwidthChannel2, e.OrigVideoCapResolutionChannel2, e.OrigVideoTransportAddressIpChannel2, e.OrigVideoTransportAddressPortChannel2, e.OrigVideoChannelRoleChannel2, e.DestVideoCapCodecChannel2, e.DestVideoCapBandwidthChannel2, e.DestVideoCapResolutionChannel2, e.DestVideoTransportAddressIpChannel2, e.DestVideoTransportAddressPortChannel2, e.DestVideoChannelRoleChannel2, e.IncomingProtocolId, e.IncomingProtocolCallRef, e.OutgoingProtocolId, e.OutgoingProtocolCallRef, e.CurrentRoutingReason, e.OrigRoutingReason, e.LastRedirectingRoutingReason, e.HuntPilotPartition, e.HuntPilotDn, e.CalledPartyPatternUsage, e.IncomingIcid, e.IncomingOrigIoi, e.IncomingTermIoi, e.OutgoingIcid, e.OutgoingOrigIoi, e.OutgoingTermIoi, e.OutpulsedOriginalCalledPartyNumber, e.OutpulsedLastRedirectingNumber, e.WasCallQueued, e.TotalWaitTimeInQueue, e.CallingPartyNumberUri, e.OriginalCalledPartyNumberUri, e.FinalCalledPartyNumberUri, e.LastRedirectDnUri, e.MobileCallingPartyNumber, e.FinalMobileCalledPartyNumber, e.OrigMobileDeviceName, e.DestMobileDeviceName, e.OrigMobileCallDuration, e.DestMobileCallDuration, e.MobileCallType, e.OriginalCalledPartyPattern, e.FinalCalledPartyPattern, e.LastRedirectingPartyPattern, e.HuntPilotPattern, e.DateTimeDisconnect })
                    .HasName("_dta_index_Calls_5_517576882__K56D_1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31_32_33_");

                entity.HasIndex(e => new { e.Year, e.Month, e.Day, e.Hour, e.Minute, e.DayOfWeek, e.CdrRecordType, e.GlobalCallIdCallManagerId, e.GlobalCallIdCallId, e.OrigLegCallIdentifier, e.DateTimeOrigination, e.OrigNodeId, e.OrigSpan, e.OrigIpAddr, e.CallingPartyUnicodeLoginUserId, e.OrigCauseLocation, e.OrigCauseValue, e.OrigPrecedenceLevel, e.OrigMediaTransportAddressIp, e.OrigMediaTransportAddressPort, e.OrigMediaCapPayloadCapability, e.OrigMediaCapMaxFramesPerPacket, e.OrigMediaCapG723BitRate, e.OrigVideoCapCodec, e.OrigVideoCapBandwidth, e.OrigVideoCapResolution, e.OrigVideoTransportAddressIp, e.OrigVideoTransportAddressPort, e.OrigRsvpaudioStat, e.OrigRsvpvideoStat, e.DestLegIdentifier, e.DestNodeId, e.DestSpan, e.DestIpAddr, e.FinalCalledPartyUnicodeLoginUserId, e.DestCauseLocation, e.DestCauseValue, e.DestPrecedenceLevel, e.DestMediaTransportAddressIp, e.DestMediaTransportAddressPort, e.DestMediaCapPayloadCapability, e.DestMediaCapMaxFramesPerPacket, e.DestMediaCapG723BitRate, e.DestVideoCapCodec, e.DestVideoCapBandwidth, e.DestVideoCapResolution, e.DestVideoTransportAddressIp, e.DestVideoTransportAddressPort, e.DestRsvpaudioStat, e.DestRsvpvideoStat, e.DateTimeConnect, e.LastRedirectDn, e.OriginalCalledPartyNumberPartition, e.CallingPartyNumberPartition, e.FinalCalledPartyNumberPartition, e.LastRedirectDnPartition, e.Duration, e.OrigDeviceName, e.DestDeviceName, e.OrigCallTerminationOnBehalfOf, e.DestCallTerminationOnBehalfOf, e.OrigCalledPartyRedirectOnBehalfOf, e.LastRedirectRedirectOnBehalfOf, e.OrigCalledPartyRedirectReason, e.LastRedirectRedirectReason, e.DestConversationId, e.GlobalCallIdClusterId, e.JoinOnBehalfOf, e.Comment, e.AuthCodeDescription, e.AuthorizationLevel, e.ClientMatterCode, e.OrigDtmfmethod, e.DestDtmfmethod, e.CallSecuredStatus, e.OrigConversationId, e.OrigMediaCapBandwidth, e.DestMediaCapBandwidth, e.AuthorizationCodeValue, e.OutpulsedCallingPartyNumber, e.OutpulsedCalledPartyNumber, e.OrigIpv4v6Addr, e.DestIpv4v6Addr, e.OrigVideoCapCodecChannel2, e.OrigVideoCapBandwidthChannel2, e.OrigVideoCapResolutionChannel2, e.OrigVideoTransportAddressIpChannel2, e.OrigVideoTransportAddressPortChannel2, e.OrigVideoChannelRoleChannel2, e.DestVideoCapCodecChannel2, e.DestVideoCapBandwidthChannel2, e.DestVideoCapResolutionChannel2, e.DestVideoTransportAddressIpChannel2, e.DestVideoTransportAddressPortChannel2, e.DestVideoChannelRoleChannel2, e.IncomingProtocolId, e.IncomingProtocolCallRef, e.OutgoingProtocolId, e.OutgoingProtocolCallRef, e.CurrentRoutingReason, e.OrigRoutingReason, e.LastRedirectingRoutingReason, e.HuntPilotPartition, e.HuntPilotDn, e.CalledPartyPatternUsage, e.IncomingIcid, e.IncomingOrigIoi, e.IncomingTermIoi, e.OutgoingIcid, e.OutgoingOrigIoi, e.OutgoingTermIoi, e.OutpulsedOriginalCalledPartyNumber, e.OutpulsedLastRedirectingNumber, e.WasCallQueued, e.TotalWaitTimeInQueue, e.CallingPartyNumberUri, e.OriginalCalledPartyNumberUri, e.FinalCalledPartyNumberUri, e.LastRedirectDnUri, e.MobileCallingPartyNumber, e.FinalMobileCalledPartyNumber, e.OrigMobileDeviceName, e.DestMobileDeviceName, e.OrigMobileCallDuration, e.DestMobileCallDuration, e.MobileCallType, e.OriginalCalledPartyPattern, e.FinalCalledPartyPattern, e.LastRedirectingPartyPattern, e.HuntPilotPattern, e.OriginalCalledPartyNumber, e.FinalCalledPartyNumber, e.DateTimeDisconnect, e.CallingPartyNumber, e.Pkid })
                    .HasName("_dta_index_Calls_5_517576882__K37_K38_K56_K16_K1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_17_18_19_20_21_22_23_24_25_26_27_28_29_30_");

                entity.Property(e => e.Pkid)
                    .HasColumnName("pkid")
                    .HasMaxLength(128);

                entity.Property(e => e.AuthCodeDescription)
                    .HasColumnName("authCodeDescription")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.AuthorizationCodeValue)
                    .HasColumnName("authorizationCodeValue")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.AuthorizationLevel)
                    .HasColumnName("authorizationLevel")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CallSecuredStatus)
                    .HasColumnName("callSecuredStatus")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CalledPartyPatternUsage)
                    .HasColumnName("calledPartyPatternUsage")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CallingPartyNumber)
                    .HasColumnName("callingPartyNumber")
                    .HasMaxLength(64);

                entity.Property(e => e.CallingPartyNumberPartition)
                    .HasColumnName("callingPartyNumberPartition")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CallingPartyNumberUri)
                    .HasColumnName("callingPartyNumber_uri")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CallingPartyUnicodeLoginUserId)
                    .HasColumnName("callingPartyUnicodeLoginUserID")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CdrRecordType)
                    .HasColumnName("cdrRecordType")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.ClientMatterCode)
                    .HasColumnName("clientMatterCode")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.CurrentRoutingReason)
                    .HasColumnName("currentRoutingReason")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DateTimeConnect)
                    .HasColumnName("dateTimeConnect")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DateTimeDisconnect)
                    .HasColumnName("dateTimeDisconnect")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeOrigination)
                    .HasColumnName("dateTimeOrigination")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestCallTerminationOnBehalfOf)
                    .HasColumnName("destCallTerminationOnBehalfOf")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestCauseLocation)
                    .HasColumnName("destCause_location")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestCauseValue)
                    .HasColumnName("destCause_value")
                    .HasMaxLength(64);

                entity.Property(e => e.DestConversationId)
                    .HasColumnName("destConversationId")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestDeviceName)
                    .HasColumnName("destDeviceName")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDtmfmethod)
                    .HasColumnName("destDTMFMethod")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestIpAddr)
                    .HasColumnName("destIpAddr")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestIpv4v6Addr)
                    .HasColumnName("destIpv4v6Addr")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestLegIdentifier)
                    .HasColumnName("destLegIdentifier")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMediaCapBandwidth)
                    .HasColumnName("destMediaCap_Bandwidth")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMediaCapG723BitRate)
                    .HasColumnName("destMediaCap_g723BitRate")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMediaCapMaxFramesPerPacket)
                    .HasColumnName("destMediaCap_maxFramesPerPacket")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMediaCapPayloadCapability)
                    .HasColumnName("destMediaCap_payloadCapability")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMediaTransportAddressIp)
                    .HasColumnName("destMediaTransportAddress_IP")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMediaTransportAddressPort)
                    .HasColumnName("destMediaTransportAddress_Port")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMobileCallDuration)
                    .HasColumnName("destMobileCallDuration")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestMobileDeviceName)
                    .HasColumnName("destMobileDeviceName")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestNodeId)
                    .HasColumnName("destNodeId")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestPrecedenceLevel)
                    .HasColumnName("destPrecedenceLevel")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestRsvpaudioStat)
                    .HasColumnName("destRSVPAudioStat")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestRsvpvideoStat)
                    .HasColumnName("destRSVPVideoStat")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestSpan)
                    .HasColumnName("destSpan")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoCapBandwidth)
                    .HasColumnName("destVideoCap_Bandwidth")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoCapBandwidthChannel2)
                    .HasColumnName("destVideoCap_Bandwidth_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoCapCodec)
                    .HasColumnName("destVideoCap_Codec")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoCapCodecChannel2)
                    .HasColumnName("destVideoCap_Codec_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoCapResolution)
                    .HasColumnName("destVideoCap_Resolution")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoCapResolutionChannel2)
                    .HasColumnName("destVideoCap_Resolution_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoChannelRoleChannel2)
                    .HasColumnName("destVideoChannel_Role_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoTransportAddressIp)
                    .HasColumnName("destVideoTransportAddress_IP")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoTransportAddressIpChannel2)
                    .HasColumnName("destVideoTransportAddress_IP_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoTransportAddressPort)
                    .HasColumnName("destVideoTransportAddress_Port")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DestVideoTransportAddressPortChannel2)
                    .HasColumnName("destVideoTransportAddress_Port_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.FinalCalledPartyNumber)
                    .HasColumnName("finalCalledPartyNumber")
                    .HasMaxLength(64);

                entity.Property(e => e.FinalCalledPartyNumberPartition)
                    .HasColumnName("finalCalledPartyNumberPartition")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.FinalCalledPartyNumberUri)
                    .HasColumnName("finalCalledPartyNumber_uri")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.FinalCalledPartyPattern)
                    .HasColumnName("finalCalledPartyPattern")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.FinalCalledPartyUnicodeLoginUserId)
                    .HasColumnName("finalCalledPartyUnicodeLoginUserID")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.FinalMobileCalledPartyNumber)
                    .HasColumnName("finalMobileCalledPartyNumber")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.GlobalCallIdCallId)
                    .HasColumnName("globalCallID_callId")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.GlobalCallIdCallManagerId)
                    .HasColumnName("globalCallID_callManagerId")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.GlobalCallIdClusterId)
                    .HasColumnName("globalCallId_ClusterID")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.HuntPilotDn)
                    .HasColumnName("huntPilotDN")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.HuntPilotPartition)
                    .HasColumnName("huntPilotPartition")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.HuntPilotPattern)
                    .HasColumnName("huntPilotPattern")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.IncomingIcid)
                    .HasColumnName("IncomingICID")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.IncomingOrigIoi)
                    .HasColumnName("IncomingOrigIOI")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.IncomingProtocolCallRef).HasColumnType("nvarchar(max)");

                entity.Property(e => e.IncomingProtocolId)
                    .HasColumnName("IncomingProtocolID")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.IncomingTermIoi)
                    .HasColumnName("IncomingTermIOI")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.JoinOnBehalfOf)
                    .HasColumnName("joinOnBehalfOf")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.LastRedirectDn)
                    .HasColumnName("lastRedirectDn")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.LastRedirectDnPartition)
                    .HasColumnName("lastRedirectDnPartition")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.LastRedirectDnUri)
                    .HasColumnName("lastRedirectDn_uri")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.LastRedirectRedirectOnBehalfOf)
                    .HasColumnName("lastRedirectRedirectOnBehalfOf")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.LastRedirectRedirectReason)
                    .HasColumnName("lastRedirectRedirectReason")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.LastRedirectingPartyPattern)
                    .HasColumnName("lastRedirectingPartyPattern")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.LastRedirectingRoutingReason)
                    .HasColumnName("lastRedirectingRoutingReason")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.MobileCallType)
                    .HasColumnName("mobileCallType")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.MobileCallingPartyNumber)
                    .HasColumnName("mobileCallingPartyNumber")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigCallTerminationOnBehalfOf)
                    .HasColumnName("origCallTerminationOnBehalfOf")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigCalledPartyRedirectOnBehalfOf)
                    .HasColumnName("origCalledPartyRedirectOnBehalfOf")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigCalledPartyRedirectReason)
                    .HasColumnName("origCalledPartyRedirectReason")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigCauseLocation)
                    .HasColumnName("origCause_location")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigCauseValue)
                    .HasColumnName("origCause_value")
                    .HasMaxLength(64);

                entity.Property(e => e.OrigConversationId)
                    .HasColumnName("origConversationId")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigDeviceName)
                    .HasColumnName("origDeviceName")
                    .HasMaxLength(64);

                entity.Property(e => e.OrigDtmfmethod)
                    .HasColumnName("origDTMFMethod")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigIpAddr)
                    .HasColumnName("origIpAddr")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigIpv4v6Addr)
                    .HasColumnName("origIpv4v6Addr")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigLegCallIdentifier)
                    .HasColumnName("origLegCallIdentifier")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMediaCapBandwidth)
                    .HasColumnName("origMediaCap_Bandwidth")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMediaCapG723BitRate)
                    .HasColumnName("origMediaCap_g723BitRate")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMediaCapMaxFramesPerPacket)
                    .HasColumnName("origMediaCap_maxFramesPerPacket")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMediaCapPayloadCapability)
                    .HasColumnName("origMediaCap_payloadCapability")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMediaTransportAddressIp)
                    .HasColumnName("origMediaTransportAddress_IP")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMediaTransportAddressPort)
                    .HasColumnName("origMediaTransportAddress_Port")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMobileCallDuration)
                    .HasColumnName("origMobileCallDuration")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigMobileDeviceName)
                    .HasColumnName("origMobileDeviceName")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigNodeId)
                    .HasColumnName("origNodeId")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigPrecedenceLevel)
                    .HasColumnName("origPrecedenceLevel")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigRoutingReason)
                    .HasColumnName("origRoutingReason")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigRsvpaudioStat)
                    .HasColumnName("origRSVPAudioStat")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigRsvpvideoStat)
                    .HasColumnName("origRSVPVideoStat")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigSpan)
                    .HasColumnName("origSpan")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoCapBandwidth)
                    .HasColumnName("origVideoCap_Bandwidth")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoCapBandwidthChannel2)
                    .HasColumnName("origVideoCap_Bandwidth_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoCapCodec)
                    .HasColumnName("origVideoCap_Codec")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoCapCodecChannel2)
                    .HasColumnName("origVideoCap_Codec_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoCapResolution)
                    .HasColumnName("origVideoCap_Resolution")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoCapResolutionChannel2)
                    .HasColumnName("origVideoCap_Resolution_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoChannelRoleChannel2)
                    .HasColumnName("origVideoChannel_Role_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoTransportAddressIp)
                    .HasColumnName("origVideoTransportAddress_IP")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoTransportAddressIpChannel2)
                    .HasColumnName("origVideoTransportAddress_IP_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoTransportAddressPort)
                    .HasColumnName("origVideoTransportAddress_Port")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OrigVideoTransportAddressPortChannel2)
                    .HasColumnName("origVideoTransportAddress_Port_Channel2")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OriginalCalledPartyNumber)
                    .HasColumnName("originalCalledPartyNumber")
                    .HasMaxLength(64);

                entity.Property(e => e.OriginalCalledPartyNumberPartition)
                    .HasColumnName("originalCalledPartyNumberPartition")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OriginalCalledPartyNumberUri)
                    .HasColumnName("originalCalledPartyNumber_uri")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OriginalCalledPartyPattern)
                    .HasColumnName("originalCalledPartyPattern")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutgoingIcid)
                    .HasColumnName("OutgoingICID")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutgoingOrigIoi)
                    .HasColumnName("OutgoingOrigIOI")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutgoingProtocolCallRef).HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutgoingProtocolId)
                    .HasColumnName("OutgoingProtocolID")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutgoingTermIoi)
                    .HasColumnName("OutgoingTermIOI")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutpulsedCalledPartyNumber)
                    .HasColumnName("outpulsedCalledPartyNumber")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutpulsedCallingPartyNumber)
                    .HasColumnName("outpulsedCallingPartyNumber")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutpulsedLastRedirectingNumber)
                    .HasColumnName("outpulsedLastRedirectingNumber")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.OutpulsedOriginalCalledPartyNumber)
                    .HasColumnName("outpulsedOriginalCalledPartyNumber")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.TotalWaitTimeInQueue)
                    .HasColumnName("totalWaitTimeInQueue")
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.WasCallQueued)
                    .HasColumnName("wasCallQueued")
                    .HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
