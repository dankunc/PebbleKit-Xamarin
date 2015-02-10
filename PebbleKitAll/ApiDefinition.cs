using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

using CoreFoundation;

namespace PebbleKitAll
{

	// @interface PBWatch : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBWatch {

		// @property (readonly, nonatomic, getter = isConnected) BOOL connected;
		[Export ("connected")]
		bool Connected { [Bind ("isConnected")] get; }

		// @property (readonly, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSString * serialNumber;
		[Export ("serialNumber")]
		string SerialNumber { get; }

		// @property (readonly, nonatomic) PBVersionInfo * versionInfo;
		[Export ("versionInfo")]
		PBVersionInfo VersionInfo { get; }

		// @property (readwrite, nonatomic, weak) id<PBWatchDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<PBWatchDelegate> delegate;
		[Wrap ("WeakDelegate")]
		PBWatchDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, strong) id userInfo;
		[Export ("userInfo", ArgumentSemantic.Retain)]
		NSObject UserInfo { get; set; }

		// @property (readonly, nonatomic) NSDate * lastConnectedDate;
		[Export ("lastConnectedDate")]
		NSDate LastConnectedDate { get; }

		// -(NSString *)friendlyDescription;
		[Export ("friendlyDescription")]
		string FriendlyDescription ();

		// -(void)closeSession:(void (^)(void))onDone;
		[Export ("closeSession:")]
		void CloseSession (Action onDone);
	}

	// @protocol PBWatchDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBWatchDelegate {

		// @optional -(void)watchDidDisconnect:(PBWatch *)watch;
		[Export ("watchDidDisconnect:")]
		void WatchDidDisconnect (PBWatch watch);

		// @optional -(void)watch:(PBWatch *)watch handleError:(NSError *)error;
		[Export ("watch:handleError:")]
		void HandleError (PBWatch watch, NSError error);

		// @optional -(void)watchWillResetSession:(PBWatch *)watch;
		[Export ("watchWillResetSession:")]
		void WatchWillResetSession (PBWatch watch);

		// @optional -(void)watchDidOpenSession:(PBWatch *)watch;
		[Export ("watchDidOpenSession:")]
		void WatchDidOpenSession (PBWatch watch);

		// @optional -(void)watchDidCloseSession:(PBWatch *)watch;
		[Export ("watchDidCloseSession:")]
		void WatchDidCloseSession (PBWatch watch);
	}



	// @interface PBPebbleCentral : NSObject
	[Protocol]
	[BaseType (typeof (NSObject))]
	interface PBPebbleCentral {

		// @property (readonly, nonatomic, strong) NSArray * connectedWatches;
		[Export ("connectedWatches", ArgumentSemantic.Retain)]
		NSObject [] ConnectedWatches { get; }

		// @property (readonly, nonatomic, strong) NSArray * registeredWatches;
		[Export ("registeredWatches", ArgumentSemantic.Retain)]
		NSObject [] RegisteredWatches { get; }

		// @property (readwrite, nonatomic, weak) id<PBPebbleCentralDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, nonatomic, weak) id<PBPebbleCentralDelegate> delegate;
		[Wrap ("WeakDelegate")]
		PBPebbleCentralDelegate Delegate { get; set; }

		// @property (readwrite, nonatomic, strong) NSData * appUUID;
		[Export ("appUUID", ArgumentSemantic.Retain)]
		NSData AppUUID { get; set; }

		// @property (readonly, nonatomic) PBDataLoggingService * dataLoggingService;
		[Export ("dataLoggingService")]
		PBDataLoggingService DataLoggingService { get; }

		// +(PBPebbleCentral *)defaultCentral;
		[Static, Export ("defaultCentral")]
		PBPebbleCentral DefaultCentral ();

		// +(void)addLumberjackLoggers;
		[Static, Export ("addLumberjackLoggers")]
		void AddLumberjackLoggers ();

		// +(void)setDebugLogsEnabled:(BOOL)logsEnabled;
		[Static, Export ("setDebugLogsEnabled:")]
		void SetDebugLogsEnabled (bool logsEnabled);

		// -(BOOL)hasValidAppUUID;
		[Export ("hasValidAppUUID")]
		bool HasValidAppUUID ();

		// -(BOOL)isMobileAppInstalled;
		[Export ("isMobileAppInstalled")]
		bool IsMobileAppInstalled ();

		// -(void)installMobileApp;
		[Export ("installMobileApp")]
		void InstallMobileApp ();

		// -(void)unregisterAllWatches;
		[Export ("unregisterAllWatches")]
		void UnregisterAllWatches ();

		// -(PBWatch *)lastConnectedWatch;
		[Export ("lastConnectedWatch")]
		PBWatch LastConnectedWatch ();
	}

	// @protocol PBPebbleCentralDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBPebbleCentralDelegate {

		// @optional -(void)pebbleCentral:(PBPebbleCentral *)central watchDidConnect:(PBWatch *)watch isNew:(BOOL)isNew;
		[Export ("pebbleCentral:watchDidConnect:isNew:")]
		void WatchDidConnect (PBPebbleCentral central, PBWatch watch, bool isNew);

		// @optional -(void)pebbleCentral:(PBPebbleCentral *)central watchDidDisconnect:(PBWatch *)watch;
		[Export ("pebbleCentral:watchDidDisconnect:")]
		void WatchDidDisconnect (PBPebbleCentral central, PBWatch watch);
	}

	// @interface Ping (PBWatch)
	[Category]
	[BaseType (typeof (PBWatch))]
	interface Ping {

		// -(void)pingWithCookie:(UInt32)cookie onPong:(void (^)(PBWatch *, UInt32))onPong onTimeout:(void (^)(PBWatch *, UInt32))onTimeout;
		[Export ("pingWithCookie:onPong:onTimeout:")]
		void PingWithCookie (nuint cookie, Action<PBWatch, nuint> onPong, Action<PBWatch, nuint> onTimeout);
	}

	// @interface PBFirmwareVersion : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBFirmwareVersion {

		// @property (readonly, nonatomic) NSInteger os;
		[Export ("os")]
		nint Os { get; }

		// @property (readonly, nonatomic) NSInteger major;
		[Export ("major")]
		nint Major { get; }

		// @property (readonly, nonatomic) NSInteger minor;
		[Export ("minor")]
		nint Minor { get; }

		// @property (readonly, copy, nonatomic) NSString * suffix;
		[Export ("suffix")]
		string Suffix { get; }

		// @property (readonly, nonatomic) UInt32 timestamp;
		[Export ("timestamp")]
		nuint Timestamp { get; }

		// @property (readonly, copy, nonatomic) NSString * commitHash;
		[Export ("commitHash")]
		string CommitHash { get; }

		// @property (readonly, copy, nonatomic) NSString * tag;
		[Export ("tag")]
		string Tag { get; }

		// +(PBFirmwareVersion *)firmwareVersionWithTag:(NSString *)tag commitHash:(NSString *)commitHash timestamp:(UInt32)timestamp;
		[Static, Export ("firmwareVersionWithTag:commitHash:timestamp:")]
		PBFirmwareVersion FirmwareVersionWithTag (string tag, string commitHash, nuint timestamp);

		// +(PBFirmwareVersion *)firmwareVersionWithOS:(NSInteger)os major:(NSInteger)major minor:(NSInteger)minor suffix:(NSString *)suffix commitHash:(NSString *)commitHash timestamp:(UInt32)timestamp;
		[Static, Export ("firmwareVersionWithOS:major:minor:suffix:commitHash:timestamp:")]
		PBFirmwareVersion FirmwareVersionWithOS (nint os, nint major, nint minor, string suffix, string commitHash, nuint timestamp);

		// -(NSComparisonResult)compare:(PBFirmwareVersion *)aVersion;
		[Export ("compare:")]
		NSComparisonResult Compare (PBFirmwareVersion aVersion);

		// -(BOOL)isEqualOrNewer:(PBFirmwareVersion *)other;
		[Export ("isEqualOrNewer:")]
		bool IsEqualOrNewer (PBFirmwareVersion other);

		// -(BOOL)isNewer:(PBFirmwareVersion *)other;
		[Export ("isNewer:")]
		bool IsNewer (PBFirmwareVersion other);

		// -(BOOL)isEqualVersionOnly:(PBFirmwareVersion *)other;
		[Export ("isEqualVersionOnly:")]
		bool IsEqualVersionOnly (PBFirmwareVersion other);
	}

	// @interface PBFirmwareMetadata : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBFirmwareMetadata {

		// @property (readonly, nonatomic) PBFirmwareVersion * version;
		[Export ("version")]
		PBFirmwareVersion Version { get; }

		// @property (readonly, nonatomic) BOOL isRecoveryFirmware;
		[Export ("isRecoveryFirmware")]
		bool IsRecoveryFirmware { get; }

		// @property (readonly, nonatomic) FirmwareMetadataPlatform hardwarePlatform;
		[Export ("hardwarePlatform")]
		FirmwareMetadataPlatform HardwarePlatform { get; }

		// +(NSString *)hardwarePlatformToString:(FirmwareMetadataPlatform)hardwarePlatform;
		[Static, Export ("hardwarePlatformToString:")]
		string HardwarePlatformToString (FirmwareMetadataPlatform hardwarePlatform);

		// +(FirmwareMetadataPlatform)stringToHardwarePlatform:(NSString *)hardwarePlatformString;
		[Static, Export ("stringToHardwarePlatform:")]
		FirmwareMetadataPlatform StringToHardwarePlatform (string hardwarePlatformString);
	}

	// @interface PBResourceMetadata : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBResourceMetadata {

		// @property (readonly, nonatomic) UInt32 timestamp;
		[Export ("timestamp")]
		nuint Timestamp { get; }

		// @property (readonly, nonatomic) UInt32 crc;
		[Export ("crc")]
		nuint Crc { get; }

		// @property (readonly, nonatomic, strong) NSString * friendlyVersion;
		[Export ("friendlyVersion", ArgumentSemantic.Retain)]
		string FriendlyVersion { get; }

		// -(BOOL)isValid;
		[Export ("isValid")]
		bool IsValid ();
	}

	// @interface PBVersionInfo : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBVersionInfo {

		// @property (readonly, nonatomic, strong) PBFirmwareMetadata * runningFirmwareMetadata;
		[Export ("runningFirmwareMetadata", ArgumentSemantic.Retain)]
		PBFirmwareMetadata RunningFirmwareMetadata { get; }

		// @property (readonly, nonatomic, strong) PBFirmwareMetadata * recoveryFirmwareMetadata;
		[Export ("recoveryFirmwareMetadata", ArgumentSemantic.Retain)]
		PBFirmwareMetadata RecoveryFirmwareMetadata { get; }

		// @property (readonly, nonatomic, strong) PBResourceMetadata * systemResources;
		[Export ("systemResources", ArgumentSemantic.Retain)]
		PBResourceMetadata SystemResources { get; }

		// @property (readonly, nonatomic) UInt32 bootloaderVersion;
		[Export ("bootloaderVersion")]
		nuint BootloaderVersion { get; }

		// @property (readonly, nonatomic, strong) NSString * hardwareVersion;
		[Export ("hardwareVersion", ArgumentSemantic.Retain)]
		string HardwareVersion { get; }

		// @property (readonly, nonatomic, strong) NSString * serialNumber;
		[Export ("serialNumber", ArgumentSemantic.Retain)]
		string SerialNumber { get; }

		// @property (readonly, nonatomic, strong) NSData * deviceAddress;
		[Export ("deviceAddress", ArgumentSemantic.Retain)]
		NSData DeviceAddress { get; }

		// -(BOOL)hasRecoveryFirmware;
		[Export ("hasRecoveryFirmware")]
		bool HasRecoveryFirmware ();

		// -(BOOL)hasSystemResources;
		[Export ("hasSystemResources")]
		bool HasSystemResources ();
	}

	// @interface Version (PBWatch)
	[Category]
	[BaseType (typeof (PBWatch))]
	interface Version {

		// -(void)getVersionInfo:(void (^)(PBWatch *, PBVersionInfo *))handler onTimeout:(void (^)(PBWatch *))onTimeout;
		[Export ("getVersionInfo:onTimeout:")]
		void GetVersionInfo (Action<PBWatch, PBVersionInfo> handler, Action<PBWatch> onTimeout);
	}

	// @interface Pebble (NSError)
	[Category]
	[BaseType (typeof (NSError))]
	interface Pebble {

		// +(NSError *)pebbleErrorWithCode:(PBErrorCode)code underLyingError:(NSError *)error;
		[Static, Export ("pebbleErrorWithCode:underLyingError:")]
		NSError PebbleErrorWithCode (PBErrorCode code, NSError error);

		// +(NSError *)pebbleErrorWithCode:(PBErrorCode)code;
		[Static, Export ("pebbleErrorWithCode:")]
		NSError PebbleErrorWithCode (PBErrorCode code);
	}

	// @interface AppMessages (PBWatch)
	[Category]
	[BaseType (typeof (PBWatch))]
	interface AppMessages {

		// -(void)appMessagesGetIsSupported:(void (^)(PBWatch *, BOOL))fetchedBlock;
		[Export ("appMessagesGetIsSupported:")]
		void AppMessagesGetIsSupported (Action<PBWatch, bool> fetchedBlock);

		// -(void)appMessagesPushUpdate:(NSDictionary *)dictionary onSent:(void (^)(PBWatch *, NSDictionary *, NSError *))onSent;
		[Export ("appMessagesPushUpdate:onSent:")]
		void AppMessagesPushUpdate (NSDictionary dictionary, Action<PBWatch, NSDictionary, NSError> onSent);

		// -(void)appMessagesPushUpdate:(NSDictionary *)dictionary withUUID:(NSData *)uuid onSent:(void (^)(PBWatch *, NSDictionary *, NSError *))onSent;
		[Export ("appMessagesPushUpdate:withUUID:onSent:")]
		void AppMessagesPushUpdate (NSDictionary dictionary, NSData uuid, Action<PBWatch, NSDictionary, NSError> onSent);

		// -(id)appMessagesAddReceiveUpdateHandler:(BOOL (^)(PBWatch *, NSDictionary *))onReceive;
		[Export ("appMessagesAddReceiveUpdateHandler:")]
		NSObject AppMessagesAddReceiveUpdateHandler (Func<PBWatch, NSDictionary, sbyte> onReceive);

		// -(id)appMessagesAddReceiveUpdateHandler:(BOOL (^)(PBWatch *, NSDictionary *))onReceive withUUID:(NSData *)uuid;
		[Export ("appMessagesAddReceiveUpdateHandler:withUUID:")]
		NSObject AppMessagesAddReceiveUpdateHandler (Func<PBWatch, NSDictionary, sbyte> onReceive, NSData uuid);

		// -(void)appMessagesRemoveUpdateHandler:(id)opaqueHandle;
		[Export ("appMessagesRemoveUpdateHandler:")]
		void AppMessagesRemoveUpdateHandler (NSObject opaqueHandle);

		// -(void)appMessagesLaunch:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("appMessagesLaunch:")]
		void AppMessagesLaunch (Action<PBWatch, NSError> onSent);

		// -(void)appMessagesLaunch:(void (^)(PBWatch *, NSError *))onSent withUUID:(NSData *)uuid;
		[Export ("appMessagesLaunch:withUUID:")]
		void AppMessagesLaunch (Action<PBWatch, NSError> onSent, NSData uuid);

		// -(void)appMessagesKill:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("appMessagesKill:")]
		void AppMessagesKill (Action<PBWatch, NSError> onSent);

		// -(void)appMessagesKill:(void (^)(PBWatch *, NSError *))onSent withUUID:(NSData *)uuid;
		[Export ("appMessagesKill:withUUID:")]
		void AppMessagesKill (Action<PBWatch, NSError> onSent, NSData uuid);
	}

	// @interface stdint (NSNumber)
	[Category]
	[BaseType (typeof (NSNumber))]
	interface stdint {

		// -(uint32_t)uint32Value;
		[Export ("uint32Value")]
		uint Uint32Value ();

		// -(uint16_t)uint16Value;
		[Export ("uint16Value")]
		ushort Uint16Value ();

		// -(uint8_t)uint8Value;
		[Export ("uint8Value")]
		byte Uint8Value ();

		// -(int32_t)int32Value;
		[Export ("int32Value")]
		int Int32Value ();

		// -(int16_t)int16Value;
		[Export ("int16Value")]
		short Int16Value ();

		// -(int8_t)int8Value;
		[Export ("int8Value")]
		sbyte Int8Value ();

		// +(NSNumber *)numberWithUint32:(uint32_t)value;
		[Static, Export ("numberWithUint32:")]
		NSNumber NumberWithUint32 (uint value);

		// +(NSNumber *)numberWithUint16:(uint16_t)value;
		[Static, Export ("numberWithUint16:")]
		NSNumber NumberWithUint16 (ushort value);

		// +(NSNumber *)numberWithUint8:(uint8_t)value;
		[Static, Export ("numberWithUint8:")]
		NSNumber NumberWithUint8 (byte value);

		// +(NSNumber *)numberWithInt32:(int32_t)value;
		[Static, Export ("numberWithInt32:")]
		NSNumber NumberWithInt32 (int value);

		// +(NSNumber *)numberWithInt16:(int16_t)value;
		[Static, Export ("numberWithInt16:")]
		NSNumber NumberWithInt16 (short value);

		// +(NSNumber *)numberWithInt8:(int8_t)value;
		[Static, Export ("numberWithInt8:")]
		NSNumber NumberWithInt8 (sbyte value);

		// -(BOOL)isFloat;
		[Export ("isFloat")]
		bool IsFloat ();

		// -(BOOL)isSigned;
		[Export ("isSigned")]
		bool IsSigned ();

		// -(uint8_t)width;
		[Export ("width")]
		byte Width ();
	}

	// @interface PBSportsUpdate : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBSportsUpdate {

		// @property (assign, readwrite, nonatomic) NSTimeInterval time;
		[Export ("time", ArgumentSemantic.UnsafeUnretained)]
		double Time { get; set; }

		// @property (assign, readwrite, nonatomic) float distance;
		[Export ("distance", ArgumentSemantic.UnsafeUnretained)]
		float Distance { get; set; }

		// @property (assign, readwrite, nonatomic) float data;
		[Export ("data", ArgumentSemantic.UnsafeUnretained)]
		float Data { get; set; }

		// +(PBSportsUpdate *)updateWithTime:(NSTimeInterval)time distance:(float)distance data:(float)data;
		[Static, Export ("updateWithTime:distance:data:")]
		PBSportsUpdate UpdateWithTime (double time, float distance, float data);

		// -(NSDictionary *)dictionary;
		[Export ("dictionary")]
		NSDictionary Dictionary ();

		// +(NSString *)timeStringFromFloat:(float)seconds;
		[Static, Export ("timeStringFromFloat:")]
		string TimeStringFromFloat (float seconds);
	}

	// @interface Sports (PBWatch)
	[Category]
	[BaseType (typeof (PBWatch))]
	interface Sports {

		// -(void)sportsGetIsSupported:(void (^)(PBWatch *, BOOL))fetchedBlock;
		[Export ("sportsGetIsSupported:")]
		void SportsGetIsSupported (Action<PBWatch, sbyte> fetchedBlock);

		// -(void)sportsAppLaunch:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("sportsAppLaunch:")]
		void SportsAppLaunch (Action<PBWatch, NSError> onSent);

		// -(void)sportsAppKill:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("sportsAppKill:")]
		void SportsAppKill (Action<PBWatch, NSError> onSent);

		// -(void)sportsAppSetMetric:(BOOL)isMetric onSent:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("sportsAppSetMetric:onSent:")]
		void SportsAppSetMetric (bool isMetric, Action<PBWatch, NSError> onSent);

		// -(void)sportsAppSetLabel:(BOOL)isPace onSent:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("sportsAppSetLabel:onSent:")]
		void SportsAppSetLabel (bool isPace, Action<PBWatch, NSError> onSent);

		// -(void)sportsAppSetActivityState:(SportsAppActivityState)state onSent:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("sportsAppSetActivityState:onSent:")]
		void SportsAppSetActivityState (SportsAppActivityState state, Action<PBWatch, NSError> onSent);

		// -(void)sportsAppUpdate:(NSDictionary *)update onSent:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("sportsAppUpdate:onSent:")]
		void SportsAppUpdate (NSDictionary update, Action<PBWatch, NSError> onSent);

		// -(id)sportsAppAddReceiveUpdateHandler:(BOOL (^)(PBWatch *, SportsAppActivityState))onReceive;
		[Export ("sportsAppAddReceiveUpdateHandler:")]
		NSObject SportsAppAddReceiveUpdateHandler (Func<PBWatch, SportsAppActivityState , bool> onReceive);

		// -(void)sportsAppRemoveUpdateHandler:(id)opaqueHandle;
		[Export ("sportsAppRemoveUpdateHandler:")]
		void SportsAppRemoveUpdateHandler (NSObject opaqueHandle);

		// -(void)sportsSetTitle:(NSString *)title icon:(UIImage *)icon onSent:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("sportsSetTitle:icon:onSent:")]
		void SportsSetTitle (string title, UIImage icon, Action<PBWatch, NSError> onSent);
	}

	// @interface Golf (PBWatch)
	[Category]
	[BaseType (typeof (PBWatch))]
	interface Golf {

		// -(void)golfGetIsSupported:(void (^)(PBWatch *, BOOL))fetchedBlock;
		[Export ("golfGetIsSupported:")]
		void GolfGetIsSupported (Action<PBWatch, sbyte> fetchedBlock);

		// -(void)golfAppLaunch:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("golfAppLaunch:")]
		void GolfAppLaunch (Action<PBWatch, NSError> onSent);

		// -(void)golfAppKill:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("golfAppKill:")]
		void GolfAppKill (Action<PBWatch, NSError> onSent);

		// -(void)golfAppUpdate:(NSDictionary *)update onSent:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("golfAppUpdate:onSent:")]
		void GolfAppUpdate (NSDictionary update, Action<PBWatch, NSError> onSent);

		// -(id)golfAppAddReceiveUpdateHandler:(BOOL (^)(PBWatch *, GolfAppCommand))onReceive;
		[Export ("golfAppAddReceiveUpdateHandler:")]
		NSObject GolfAppAddReceiveUpdateHandler (Func<PBWatch, GolfAppCommand , bool> onReceive);

		// -(void)golfAppRemoveUpdateHandler:(id)opaqueHandle;
		[Export ("golfAppRemoveUpdateHandler:")]
		void GolfAppRemoveUpdateHandler (NSObject opaqueHandle);

		// -(void)golfSetTitle:(NSString *)title icon:(UIImage *)icon onSent:(void (^)(PBWatch *, NSError *))onSent;
		[Export ("golfSetTitle:icon:onSent:")]
		void GolfSetTitle (string title, UIImage icon, Action<PBWatch, NSError> onSent);
	}

	// @interface PBBitmap : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBBitmap {

		// @property (readonly, nonatomic, strong) NSData * pixelData;
		[Export ("pixelData", ArgumentSemantic.Retain)]
		NSData PixelData { get; }

		// @property (readonly, assign, nonatomic) uint16_t rowSizeBytes;
		[Export ("rowSizeBytes", ArgumentSemantic.UnsafeUnretained)]
		ushort RowSizeBytes { get; }

		// @property (readonly, assign, nonatomic) uint16_t infoFlags;
		[Export ("infoFlags", ArgumentSemantic.UnsafeUnretained)]
		ushort InfoFlags { get; }

		// @property (readonly, assign, nonatomic) GRect bounds;
		[Export ("bounds", ArgumentSemantic.UnsafeUnretained)]
		GRect Bounds { get; }

		// +(PBBitmap *)pebbleBitmapWithUIImage:(UIImage *)image;
		[Static, Export ("pebbleBitmapWithUIImage:")]
		PBBitmap PebbleBitmapWithUIImage (UIImage image);
	}

	// @interface PBDataLoggingSessionMetadata : NSObject <NSSecureCoding, NSCopying>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBDataLoggingSessionMetadata : INSSecureCoding, INSCopying {

		// @property (readonly, nonatomic) UInt32 tag;
		[Export ("tag")]
		nuint Tag { get; }

		// @property (readonly, nonatomic) UInt32 timestamp;
		[Export ("timestamp")]
		nuint Timestamp { get; }

		// @property (readonly, nonatomic) PBDataLoggingType type;
		[Export ("type")]
		byte Type { get; }

		// @property (readonly, nonatomic) UInt16 itemSize;
		[Export ("itemSize")]
		ushort ItemSize { get; }

		// @property (readonly, nonatomic) NSString * serialNumber;
		[Export ("serialNumber")]
		string SerialNumber { get; }

		// +(id)metadataWithTag:(UInt32)tag timestamp:(UInt32)timestamp type:(PBDataLoggingType)type itemSize:(UInt16)itemSize serialNumber:(NSString *)serialNumber;
		[Static, Export ("metadataWithTag:timestamp:type:itemSize:serialNumber:")]
		NSObject MetadataWithTag (nuint tag, nuint timestamp, byte type, ushort itemSize, string serialNumber);

		// -(BOOL)isEqualToDataLoggingSessionMetadata:(PBDataLoggingSessionMetadata *)sessionMetadata;
		[Export ("isEqualToDataLoggingSessionMetadata:")]
		bool IsEqualToDataLoggingSessionMetadata (PBDataLoggingSessionMetadata sessionMetadata);
	}

	// @protocol PBDataLoggingServiceDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBDataLoggingServiceDelegate {

		// @optional -(BOOL)dataLoggingService:(PBDataLoggingService *)service hasByteArrays:(const UInt8 *const)bytes numberOfItems:(UInt16)numberOfItems forDataLoggingSession:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:hasByteArrays:numberOfItems:forDataLoggingSession:")]
		bool HasByteArrays (PBDataLoggingService service, byte bytes, ushort numberOfItems, PBDataLoggingSessionMetadata session);

		// @optional -(BOOL)dataLoggingService:(PBDataLoggingService *)service hasUInt8s:(const UInt8 [])data numberOfItems:(UInt16)numberOfItems forDataLoggingSession:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:hasUInt8s:numberOfItems:forDataLoggingSession:")]
		bool HasUInt8s (PBDataLoggingService service, byte [] data, ushort numberOfItems, PBDataLoggingSessionMetadata session);

		// @optional -(BOOL)dataLoggingService:(PBDataLoggingService *)service hasUInt16s:(const UInt16 [])data numberOfItems:(UInt16)numberOfItems forDataLoggingSession:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:hasUInt16s:numberOfItems:forDataLoggingSession:")]
		bool HasUInt16s (PBDataLoggingService service, UInt16 [] data, ushort numberOfItems, PBDataLoggingSessionMetadata session);

		// @optional -(BOOL)dataLoggingService:(PBDataLoggingService *)service hasUInt32s:(const UInt32 [])data numberOfItems:(UInt16)numberOfItems forDataLoggingSession:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:hasUInt32s:numberOfItems:forDataLoggingSession:")]
		bool HasUInt32s (PBDataLoggingService service, UInt32 [] data, ushort numberOfItems, PBDataLoggingSessionMetadata session);

		// @optional -(BOOL)dataLoggingService:(PBDataLoggingService *)service hasSInt8s:(const SInt8 [])data numberOfItems:(UInt16)numberOfItems forDataLoggingSession:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:hasSInt8s:numberOfItems:forDataLoggingSession:")]
		bool HasSInt8s (PBDataLoggingService service, sbyte [] data, ushort numberOfItems, PBDataLoggingSessionMetadata session);

		// @optional -(BOOL)dataLoggingService:(PBDataLoggingService *)service hasSInt16s:(const SInt16 [])data numberOfItems:(UInt16)numberOfItems forDataLoggingSession:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:hasSInt16s:numberOfItems:forDataLoggingSession:")]
		bool HasSInt16s (PBDataLoggingService service, short [] data, ushort numberOfItems, PBDataLoggingSessionMetadata session);

		// @optional -(BOOL)dataLoggingService:(PBDataLoggingService *)service hasSInt32s:(const SInt32 [])data numberOfItems:(UInt16)numberOfItems forDataLoggingSession:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:hasSInt32s:numberOfItems:forDataLoggingSession:")]
		bool HasSInt32s (PBDataLoggingService service, int [] data, ushort numberOfItems, PBDataLoggingSessionMetadata session);

		// @optional -(void)dataLoggingService:(PBDataLoggingService *)service sessionDidFinish:(PBDataLoggingSessionMetadata *)session;
		[Export ("dataLoggingService:sessionDidFinish:")]
		void SessionDidFinish (PBDataLoggingService service, PBDataLoggingSessionMetadata session);
	}

	// @interface PBDataLoggingService : NSObject
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PBDataLoggingService {

		// @property (readwrite, atomic, weak) id<PBDataLoggingServiceDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (readwrite, atomic, weak) id<PBDataLoggingServiceDelegate> delegate;
		[Wrap ("WeakDelegate")]
		PBDataLoggingServiceDelegate Delegate { get; set; }

		// -(void)setDelegateQueue:(dispatch_queue_t)delegateQueue;
		[Export ("setDelegateQueue:")]
		void SetDelegateQueue (DispatchQueue delegateQueue);

		// -(void)pollForData;
		[Export ("pollForData")]
		void PollForData ();
	}

}

