using System;

namespace PebbleKitAll
{

	public enum FirmwareMetadataPlatform : uint {
		FirmwareMetadataPlatformUnknown = 0,
		FirmwareMetadataPlatformPebbleOneEV1 = 1,
		FirmwareMetadataPlatformPebbleOneEV2 = 2,
		FirmwareMetadataPlatformPebbleOneEV2_3 = 3,
		FirmwareMetadataPlatformPebbleOneEV2_4 = 4,
		FirmwareMetadataPlatformPebbleOnePointFive = 5,
		FirmwareMetadataPlatformPebbleTwoPointZero = 6,
		FirmwareMetadataPlatformPebbleOneBigboard = 255,
		FirmwareMetadataPlatformPebbleOneBigboard2 = 254
	}

	public enum PBErrorCode : uint {
		PBErrorCodeNoSupportedProtocolsInInfoPlist,
		PBErrorCodeErrorCreatingSession,
		PBErrorCodeOutputStreamError,
		PBErrorCodeInputStreamError,
		PBErrorCodeSendMessageTimeout,
		PBErrorCodeEndpointDisallowed,
		PBErrorCodeVersionInfoTimeout,
		PBErrorCodeCannotCreateSessionWhileClosing,
		PBErrorCodeNoAppUUID,
		PBErrorCodeAppMessageRejected,
		PBErrorCodeAppMessageAckTimeout,
		PBErrorCodeDictionaryUnsupportedKeyClass,
		PBErrorCodeDictionaryUnsupportedValueClass,
		PBErrorCodeDictionaryInternalConsistency,
		PBErrorCodeInvalidArguments,
		PBErrorCodePebbleAppUnreachable,
		PBErrorCodePebbleAppRequestTimeout,
		PBErrorCodePebbleAppEmptyResponse,
		PBErrorCodePebbleAppUnexpectedResponse,
		PBErrorCodeServerNotAvailable,
		PBErrorCodeDownloadFailed,
		PBErrorCodePebbleNotConnected
	}

	public enum PBAppState : byte {
		NotRunning = 0,
		Running = 1
	}

	public enum SportsAppActivityState : uint {
		SportsAppActivityStateInit = 0,
		SportsAppActivityStateRunning = 1,
		SportsAppActivityStatePaused = 2,
		SportsAppActivityStateEnd = 3
	}

	public enum GolfAppCommand : uint {
		GolfAppCommandPrevious = 1,
		GolfAppCommandNext = 2,
		GolfAppCommandSelect = 3
	}

	public enum PBDataLoggingType : uint {
		PBDataLoggingTypeByteArray = 0,
		PBDataLoggingTypeUInt = 2,
		PBDataLoggingTypeInt = 3
	}

	public struct GSize {
		public short w;
		public short h;
	}

	public struct GPoint {
		public short x;
		public short y;
	}

	public struct GRect {
		public GPoint origin;
		public GSize size;
	}

}

