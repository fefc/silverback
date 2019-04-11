﻿namespace Silverback.Messaging.Proxies
{
    public class ConfluentConsumerConfigProxy
    {
        internal Confluent.Kafka.ConsumerConfig ConfluentConfig { get; } = new Confluent.Kafka.ConsumerConfig();

        ///<summary> A comma separated list of fields that may be optionally set in <see cref="T:Confluent.Kafka.ConsumeResult`2" /> objects returned by the <see cref="M:Confluent.Kafka.Consumer`2.Consume(System.TimeSpan)" /> method. Disabling fields that you do not require will improve throughput and reduce memory consumption. Allowed values: headers, timestamp, topic, all, none default: all importance: low </summary>
        public string ConsumeResultFields {set => ConfluentConfig.ConsumeResultFields = value; }

        ///<summary> Action to take when there is no initial offset in offset store or the desired offset is out of range: 'smallest','earliest' - automatically reset the offset to the smallest offset, 'largest','latest' - automatically reset the offset to the largest offset, 'error' - trigger an error which is retrieved by consuming messages and checking 'message-&gt;err'. default: largest importance: high </summary>
        public Confluent.Kafka.AutoOffsetReset? AutoOffsetReset { get => ConfluentConfig.AutoOffsetReset; set => ConfluentConfig.AutoOffsetReset = value; }

        ///<summary> Client group id string. All clients sharing the same group.id belong to the same group. default: '' importance: high </summary>
        public string GroupId { get => ConfluentConfig.GroupId; set => ConfluentConfig.GroupId = value; }

        ///<summary> Name of partition assignment strategy to use when elected group leader assigns partitions to group members. default: range,roundrobin importance: medium </summary>
        public Confluent.Kafka.PartitionAssignmentStrategy? PartitionAssignmentStrategy { get => ConfluentConfig.PartitionAssignmentStrategy; set => ConfluentConfig.PartitionAssignmentStrategy = value; }

        ///<summary> Client group session and failure detection timeout. The consumer sends periodic heartbeats (heartbeat.interval.ms) to indicate its liveness to the broker. If no hearts are received by the broker for a group member within the session timeout, the broker will remove the consumer from the group and trigger a rebalance. The allowed range is configured with the **broker** configuration properties `group.min.session.timeout.ms` and `group.max.session.timeout.ms`. Also see `max.poll.interval.ms`. default: 10000 importance: high </summary>
        public int? SessionTimeoutMs { get => ConfluentConfig.SessionTimeoutMs; set => ConfluentConfig.SessionTimeoutMs = value; }

        ///<summary> Group session keepalive heartbeat interval. default: 3000 importance: low </summary>
        public int? HeartbeatIntervalMs { get => ConfluentConfig.HeartbeatIntervalMs; set => ConfluentConfig.HeartbeatIntervalMs = value; }

        ///<summary> Group protocol type default: consumer importance: low </summary>
        public string GroupProtocolType { get => ConfluentConfig.GroupProtocolType; set => ConfluentConfig.GroupProtocolType = value; }

        ///<summary> How often to query for the current client group coordinator. If the currently assigned coordinator is down the configured query interval will be divided by ten to more quickly recover in case of coordinator reassignment. default: 600000 importance: low </summary>
        public int? CoordinatorQueryIntervalMs { get => ConfluentConfig.CoordinatorQueryIntervalMs; set => ConfluentConfig.CoordinatorQueryIntervalMs = value; }

        ///<summary> Maximum allowed time between calls to consume messages (e.g., rd_kafka_consumer_poll()) for high-level consumers. If this interval is exceeded the consumer is considered failed and the group will rebalance in order to reassign the partitions to another consumer group member. Warning: Offset commits may be not possible at this point. Note: It is recommended to set `enable.auto.offset.store=false` for long-time processing applications and then explicitly store offsets (using offsets_store()) *after* message processing, to make sure offsets are not auto-committed prior to processing has finished. The interval is checked two times per second. See KIP-62 for more information. default: 300000 importance: high </summary>
        public int? MaxPollIntervalMs { get => ConfluentConfig.MaxPollIntervalMs; set => ConfluentConfig.MaxPollIntervalMs = value; }

        ///<summary> Automatically and periodically commit offsets in the background. Note: setting this to false does not prevent the consumer from fetching previously committed start offsets. To circumvent this behaviour set specific start offsets per partition in the call to assign(). default: true importance: high </summary>
        public bool? EnableAutoCommit { get => ConfluentConfig.EnableAutoCommit; set => ConfluentConfig.EnableAutoCommit = value; }

        ///<summary> The frequency in milliseconds that the consumer offsets are committed (written) to offset storage. (0 = disable). This setting is used by the high-level consumer. default: 5000 importance: medium </summary>
        public int? AutoCommitIntervalMs { get => ConfluentConfig.AutoCommitIntervalMs; set => ConfluentConfig.AutoCommitIntervalMs = value; }

        ///<summary> Automatically store offset of last message provided to application. The offset store is an in-memory store of the next offset to (auto-)commit for each partition. default: true importance: high </summary>
        public bool? EnableAutoOffsetStore { get => ConfluentConfig.EnableAutoOffsetStore; set => ConfluentConfig.EnableAutoOffsetStore = value; }

        ///<summary> Minimum number of messages per topic+partition librdkafka tries to maintain in the local consumer queue. default: 100000 importance: medium </summary>
        public int? QueuedMinMessages { get => ConfluentConfig.QueuedMinMessages; set => ConfluentConfig.QueuedMinMessages = value; }

        ///<summary> Maximum number of kilobytes per topic+partition in the local consumer queue. This value may be overshot by fetch.message.max.bytes. This property has higher priority than queued.min.messages. default: 1048576 importance: medium </summary>
        public int? QueuedMaxMessagesKbytes { get => ConfluentConfig.QueuedMaxMessagesKbytes; set => ConfluentConfig.QueuedMaxMessagesKbytes = value; }

        ///<summary> Maximum time the broker may wait to fill the response with fetch.min.bytes. default: 100 importance: low </summary>
        public int? FetchWaitMaxMs { get => ConfluentConfig.FetchWaitMaxMs; set => ConfluentConfig.FetchWaitMaxMs = value; }

        ///<summary> Initial maximum number of bytes per topic+partition to request when fetching messages from the broker. If the client encounters a message larger than this value it will gradually try to increase it until the entire message can be fetched. default: 1048576 importance: medium </summary>
        public int? MaxPartitionFetchBytes { get => ConfluentConfig.MaxPartitionFetchBytes; set => ConfluentConfig.MaxPartitionFetchBytes = value; }

        ///<summary> Maximum amount of data the broker shall return for a Fetch request. Messages are fetched in batches by the consumer and if the first message batch in the first non-empty partition of the Fetch request is larger than this value, then the message batch will still be returned to ensure the consumer can make progress. The maximum message batch size accepted by the broker is defined via `message.max.bytes` (broker config) or `max.message.bytes` (broker topic config). `fetch.max.bytes` is automatically adjusted upwards to be at least `message.max.bytes` (consumer config). default: 52428800 importance: medium </summary>
        public int? FetchMaxBytes { get => ConfluentConfig.FetchMaxBytes; set => ConfluentConfig.FetchMaxBytes = value; }

        ///<summary> Minimum number of bytes the broker responds with. If fetch.wait.max.ms expires the accumulated data will be sent to the client regardless of this setting. default: 1 importance: low </summary>
        public int? FetchMinBytes { get => ConfluentConfig.FetchMinBytes; set => ConfluentConfig.FetchMinBytes = value; }

        ///<summary> How long to postpone the next fetch request for a topic+partition in case of a fetch error. default: 500 importance: medium </summary>
        public int? FetchErrorBackoffMs { get => ConfluentConfig.FetchErrorBackoffMs; set => ConfluentConfig.FetchErrorBackoffMs = value; }

        ///<summary> Emit RD_KAFKA_RESP_ERR__PARTITION_EOF event whenever the consumer reaches the end of a partition. default: false importance: low </summary>
        public bool? EnablePartitionEof { get => ConfluentConfig.EnablePartitionEof; set => ConfluentConfig.EnablePartitionEof = value; }

        ///<summary> Verify CRC32 of consumed messages, ensuring no on-the-wire or on-disk corruption to the messages occurred. This check comes at slightly increased CPU usage. default: false importance: medium </summary>
        public bool? CheckCrcs { get => ConfluentConfig.CheckCrcs; set => ConfluentConfig.CheckCrcs = value; }

        ///<summary> SASL mechanism to use for authentication. Supported: GSSAPI, PLAIN, SCRAM-SHA-256, SCRAM-SHA-512. **NOTE**: Despite the name, you may not configure more than one mechanism. </summary>
        public Confluent.Kafka.SaslMechanism? SaslMechanism { get => ConfluentConfig.SaslMechanism; set => ConfluentConfig.SaslMechanism = value; }

        ///<summary> This field indicates the number of acknowledgements the leader broker must receive from ISR brokers before responding to the request: Zero=Broker does not send any response/ack to client, One=The leader will write the record to its local log but will respond without awaiting full acknowledgement from all followers. All=Broker will block until message is committed by all in sync replicas (ISRs). If there are less than min.insync.replicas (broker configuration) in the ISR set the produce request will fail. </summary>
        public Confluent.Kafka.Acks? Acks { get => ConfluentConfig.Acks; set => ConfluentConfig.Acks = value; }

        ///<summary> Client identifier. default: rdkafka importance: low </summary>
        public string ClientId { get => ConfluentConfig.ClientId; set => ConfluentConfig.ClientId = value; }

        ///<summary> Initial list of brokers as a CSV list of broker host or host:port. The application may also use `rd_kafka_brokers_add()` to add brokers during runtime. default: '' importance: high </summary>
        public string BootstrapServers { get => ConfluentConfig.BootstrapServers; set => ConfluentConfig.BootstrapServers = value; }

        ///<summary> Maximum Kafka protocol request message size. default: 1000000 importance: medium </summary>
        public int? MessageMaxBytes { get => ConfluentConfig.MessageMaxBytes; set => ConfluentConfig.MessageMaxBytes = value; }

        ///<summary> Maximum size for message to be copied to buffer. Messages larger than this will be passed by reference (zero-copy) at the expense of larger iovecs. default: 65535 importance: low </summary>
        public int? MessageCopyMaxBytes { get => ConfluentConfig.MessageCopyMaxBytes; set => ConfluentConfig.MessageCopyMaxBytes = value; }

        ///<summary> Maximum Kafka protocol response message size. This serves as a safety precaution to avoid memory exhaustion in case of protocol hickups. This value must be at least `fetch.max.bytes` + 512 to allow for protocol overhead; the value is adjusted automatically unless the configuration property is explicitly set. default: 100000000 importance: medium </summary>
        public int? ReceiveMessageMaxBytes { get => ConfluentConfig.ReceiveMessageMaxBytes; set => ConfluentConfig.ReceiveMessageMaxBytes = value; }

        ///<summary> Maximum number of in-flight requests per broker connection. This is a generic property applied to all broker communication, however it is primarily relevant to produce requests. In particular, note that other mechanisms limit the number of outstanding consumer fetch request per broker to one. default: 1000000 importance: low </summary>
        public int? MaxInFlight { get => ConfluentConfig.MaxInFlight; set => ConfluentConfig.MaxInFlight = value; }

        ///<summary> Non-topic request timeout in milliseconds. This is for metadata requests, etc. default: 60000 importance: low </summary>
        public int? MetadataRequestTimeoutMs { get => ConfluentConfig.MetadataRequestTimeoutMs; set => ConfluentConfig.MetadataRequestTimeoutMs = value; }

        ///<summary> Topic metadata refresh interval in milliseconds. The metadata is automatically refreshed on error and connect. Use -1 to disable the intervalled refresh. default: 300000 importance: low </summary>
        public int? TopicMetadataRefreshIntervalMs { get => ConfluentConfig.TopicMetadataRefreshIntervalMs; set => ConfluentConfig.TopicMetadataRefreshIntervalMs = value; }

        ///<summary> Metadata cache max age. Defaults to topic.metadata.refresh.interval.ms * 3 default: 900000 importance: low </summary>
        public int? MetadataMaxAgeMs { get => ConfluentConfig.MetadataMaxAgeMs; set => ConfluentConfig.MetadataMaxAgeMs = value; }

        ///<summary> When a topic loses its leader a new metadata request will be enqueued with this initial interval, exponentially increasing until the topic metadata has been refreshed. This is used to recover quickly from transitioning leader brokers. default: 250 importance: low </summary>
        public int? TopicMetadataRefreshFastIntervalMs { get => ConfluentConfig.TopicMetadataRefreshFastIntervalMs; set => ConfluentConfig.TopicMetadataRefreshFastIntervalMs = value; }

        ///<summary> Sparse metadata requests (consumes less network bandwidth) default: true importance: low </summary>
        public bool? TopicMetadataRefreshSparse { get => ConfluentConfig.TopicMetadataRefreshSparse; set => ConfluentConfig.TopicMetadataRefreshSparse = value; }

        ///<summary> Topic blacklist, a comma-separated list of regular expressions for matching topic names that should be ignored in broker metadata information as if the topics did not exist. default: '' importance: low </summary>
        public string TopicBlacklist { get => ConfluentConfig.TopicBlacklist; set => ConfluentConfig.TopicBlacklist = value; }

        ///<summary> A comma-separated list of debug contexts to enable. Detailed Producer debugging: broker,topic,msg. Consumer: consumer,cgrp,topic,fetch default: '' importance: medium </summary>
        public string Debug { get => ConfluentConfig.Debug; set => ConfluentConfig.Debug = value; }

        ///<summary> Default timeout for network requests. Producer: ProduceRequests will use the lesser value of `socket.timeout.ms` and remaining `message.timeout.ms` for the first message in the batch. Consumer: FetchRequests will use `fetch.wait.max.ms` + `socket.timeout.ms`. Admin: Admin requests will use `socket.timeout.ms` or explicitly set `rd_kafka_AdminOptions_set_operation_timeout()` value. default: 60000 importance: low </summary>
        public int? SocketTimeoutMs { get => ConfluentConfig.SocketTimeoutMs; set => ConfluentConfig.SocketTimeoutMs = value; }

        ///<summary> Broker socket send buffer size. System default is used if 0. default: 0 importance: low </summary>
        public int? SocketSendBufferBytes { get => ConfluentConfig.SocketSendBufferBytes; set => ConfluentConfig.SocketSendBufferBytes = value; }

        ///<summary> Broker socket receive buffer size. System default is used if 0. default: 0 importance: low </summary>
        public int? SocketReceiveBufferBytes { get => ConfluentConfig.SocketReceiveBufferBytes; set => ConfluentConfig.SocketReceiveBufferBytes = value; }

        ///<summary> Enable TCP keep-alives (SO_KEEPALIVE) on broker sockets default: false importance: low </summary>
        public bool? SocketKeepaliveEnable { get => ConfluentConfig.SocketKeepaliveEnable; set => ConfluentConfig.SocketKeepaliveEnable = value; }

        ///<summary> Disable the Nagle algorithm (TCP_NODELAY) on broker sockets. default: false importance: low </summary>
        public bool? SocketNagleDisable { get => ConfluentConfig.SocketNagleDisable; set => ConfluentConfig.SocketNagleDisable = value; }

        ///<summary> Disconnect from broker when this number of send failures (e.g., timed out requests) is reached. Disable with 0. WARNING: It is highly recommended to leave this setting at its default value of 1 to avoid the client and broker to become desynchronized in case of request timeouts. NOTE: The connection is automatically re-established. default: 1 importance: low </summary>
        public int? SocketMaxFails { get => ConfluentConfig.SocketMaxFails; set => ConfluentConfig.SocketMaxFails = value; }

        ///<summary> How long to cache the broker address resolving results (milliseconds). default: 1000 importance: low </summary>
        public int? BrokerAddressTtl { get => ConfluentConfig.BrokerAddressTtl; set => ConfluentConfig.BrokerAddressTtl = value; }

        ///<summary> Allowed broker IP address families: any, v4, v6 default: any importance: low </summary>
        public Confluent.Kafka.BrokerAddressFamily? BrokerAddressFamily { get => ConfluentConfig.BrokerAddressFamily; set => ConfluentConfig.BrokerAddressFamily = value; }

        ///<summary> The initial time to wait before reconnecting to a broker after the connection has been closed. The time is increased exponentially until `reconnect.backoff.max.ms` is reached. -25% to +50% jitter is applied to each reconnect backoff. A value of 0 disables the backoff and reconnects immediately. default: 100 importance: medium </summary>
        public int? ReconnectBackoffMs { get => ConfluentConfig.ReconnectBackoffMs; set => ConfluentConfig.ReconnectBackoffMs = value; }

        ///<summary> The maximum time to wait before reconnecting to a broker after the connection has been closed. default: 10000 importance: medium </summary>
        public int? ReconnectBackoffMaxMs { get => ConfluentConfig.ReconnectBackoffMaxMs; set => ConfluentConfig.ReconnectBackoffMaxMs = value; }

        ///<summary> librdkafka statistics emit interval. The application also needs to register a stats callback using `rd_kafka_conf_set_stats_cb()`. The granularity is 1000ms. A value of 0 disables statistics. default: 0 importance: high </summary>
        public int? StatisticsIntervalMs { get => ConfluentConfig.StatisticsIntervalMs; set => ConfluentConfig.StatisticsIntervalMs = value; }

        ///<summary> Disable spontaneous log_cb from internal librdkafka threads, instead enqueue log messages on queue set with `rd_kafka_set_log_queue()` and serve log callbacks or events through the standard poll APIs. **NOTE**: Log messages will linger in a temporary queue until the log queue has been set. default: false importance: low </summary>
        public bool? LogQueue { get => ConfluentConfig.LogQueue; set => ConfluentConfig.LogQueue = value; }

        ///<summary> Print internal thread name in log messages (useful for debugging librdkafka internals) default: true importance: low </summary>
        public bool? LogThreadName { get => ConfluentConfig.LogThreadName; set => ConfluentConfig.LogThreadName = value; }

        ///<summary> Log broker disconnects. It might be useful to turn this off when interacting with 0.9 brokers with an aggressive `connection.max.idle.ms` value. default: true importance: low </summary>
        public bool? LogConnectionClose { get => ConfluentConfig.LogConnectionClose; set => ConfluentConfig.LogConnectionClose = value; }

        ///<summary> Signal that librdkafka will use to quickly terminate on rd_kafka_destroy(). If this signal is not set then there will be a delay before rd_kafka_wait_destroyed() returns true as internal threads are timing out their system calls. If this signal is set however the delay will be minimal. The application should mask this signal as an internal signal handler is installed. default: 0 importance: low </summary>
        public int? InternalTerminationSignal { get => ConfluentConfig.InternalTerminationSignal; set => ConfluentConfig.InternalTerminationSignal = value; }

        ///<summary> Request broker's supported API versions to adjust functionality to available protocol features. If set to false, or the ApiVersionRequest fails, the fallback version `broker.version.fallback` will be used. **NOTE**: Depends on broker version &gt;=0.10.0. If the request is not supported by (an older) broker the `broker.version.fallback` fallback is used. default: true importance: high </summary>
        public bool? ApiVersionRequest { get => ConfluentConfig.ApiVersionRequest; set => ConfluentConfig.ApiVersionRequest = value; }

        ///<summary> Timeout for broker API version requests. default: 10000 importance: low </summary>
        public int? ApiVersionRequestTimeoutMs { get => ConfluentConfig.ApiVersionRequestTimeoutMs; set => ConfluentConfig.ApiVersionRequestTimeoutMs = value; }

        ///<summary> Dictates how long the `broker.version.fallback` fallback is used in the case the ApiVersionRequest fails. **NOTE**: The ApiVersionRequest is only issued when a new connection to the broker is made (such as after an upgrade). default: 0 importance: medium </summary>
        public int? ApiVersionFallbackMs { get => ConfluentConfig.ApiVersionFallbackMs; set => ConfluentConfig.ApiVersionFallbackMs = value; }

        ///<summary> Older broker versions (before 0.10.0) provide no way for a client to query for supported protocol features (ApiVersionRequest, see `api.version.request`) making it impossible for the client to know what features it may use. As a workaround a user may set this property to the expected broker version and the client will automatically adjust its feature set accordingly if the ApiVersionRequest fails (or is disabled). The fallback broker version will be used for `api.version.fallback.ms`. Valid values are: 0.9.0, 0.8.2, 0.8.1, 0.8.0. Any other value &gt;= 0.10, such as 0.10.2.1, enables ApiVersionRequests. default: 0.10.0 importance: medium </summary>
        public string BrokerVersionFallback { get => ConfluentConfig.BrokerVersionFallback; set => ConfluentConfig.BrokerVersionFallback = value; }

        ///<summary> Protocol used to communicate with brokers. default: plaintext importance: high </summary>
        public Confluent.Kafka.SecurityProtocol? SecurityProtocol { get => ConfluentConfig.SecurityProtocol; set => ConfluentConfig.SecurityProtocol = value; }

        ///<summary> A cipher suite is a named combination of authentication, encryption, MAC and key exchange algorithm used to negotiate the security settings for a network connection using TLS or SSL network protocol. See manual page for `ciphers(1)` and `SSL_CTX_set_cipher_list(3). default: '' importance: low </summary>
        public string SslCipherSuites { get => ConfluentConfig.SslCipherSuites; set => ConfluentConfig.SslCipherSuites = value; }

        ///<summary> The supported-curves extension in the TLS ClientHello message specifies the curves (standard/named, or 'explicit' GF(2^k) or GF(p)) the client is willing to have the server use. See manual page for `SSL_CTX_set1_curves_list(3)`. OpenSSL &gt;= 1.0.2 required. default: '' importance: low </summary>
        public string SslCurvesList { get => ConfluentConfig.SslCurvesList; set => ConfluentConfig.SslCurvesList = value; }

        ///<summary> The client uses the TLS ClientHello signature_algorithms extension to indicate to the server which signature/hash algorithm pairs may be used in digital signatures. See manual page for `SSL_CTX_set1_sigalgs_list(3)`. OpenSSL &gt;= 1.0.2 required. default: '' importance: low </summary>
        public string SslSigalgsList { get => ConfluentConfig.SslSigalgsList; set => ConfluentConfig.SslSigalgsList = value; }

        ///<summary> Path to client's private key (PEM) used for authentication. default: '' importance: low </summary>
        public string SslKeyLocation { get => ConfluentConfig.SslKeyLocation; set => ConfluentConfig.SslKeyLocation = value; }

        ///<summary> Private key passphrase default: '' importance: low </summary>
        public string SslKeyPassword { get => ConfluentConfig.SslKeyPassword; set => ConfluentConfig.SslKeyPassword = value; }

        ///<summary> Path to client's public key (PEM) used for authentication. default: '' importance: low </summary>
        public string SslCertificateLocation { get => ConfluentConfig.SslCertificateLocation; set => ConfluentConfig.SslCertificateLocation = value; }

        ///<summary> File or directory path to CA certificate(s) for verifying the broker's key. default: '' importance: medium </summary>
        public string SslCaLocation { get => ConfluentConfig.SslCaLocation; set => ConfluentConfig.SslCaLocation = value; }

        ///<summary> Path to CRL for verifying broker's certificate validity. default: '' importance: low </summary>
        public string SslCrlLocation { get => ConfluentConfig.SslCrlLocation; set => ConfluentConfig.SslCrlLocation = value; }

        ///<summary> Path to client's keystore (PKCS#12) used for authentication. default: '' importance: low </summary>
        public string SslKeystoreLocation { get => ConfluentConfig.SslKeystoreLocation; set => ConfluentConfig.SslKeystoreLocation = value; }

        ///<summary> Client's keystore (PKCS#12) password. default: '' importance: low </summary>
        public string SslKeystorePassword { get => ConfluentConfig.SslKeystorePassword; set => ConfluentConfig.SslKeystorePassword = value; }

        ///<summary> Kerberos principal name that Kafka runs as, not including /hostname@REALM default: kafka importance: low </summary>
        public string SaslKerberosServiceName { get => ConfluentConfig.SaslKerberosServiceName; set => ConfluentConfig.SaslKerberosServiceName = value; }

        ///<summary> This client's Kerberos principal name. (Not supported on Windows, will use the logon user's principal). default: kafkaclient importance: low </summary>
        public string SaslKerberosPrincipal { get => ConfluentConfig.SaslKerberosPrincipal; set => ConfluentConfig.SaslKerberosPrincipal = value; }

        ///<summary> Full kerberos kinit command string, %{config.prop.name} is replaced by corresponding config object value, %{broker.name} returns the broker's hostname. default: kinit -S "%{sasl.kerberos.service.name}/%{broker.name}" -k -t "%{sasl.kerberos.keytab}" %{sasl.kerberos.principal} importance: low </summary>
        public string SaslKerberosKinitCmd { get => ConfluentConfig.SaslKerberosKinitCmd; set => ConfluentConfig.SaslKerberosKinitCmd = value; }

        ///<summary> Path to Kerberos keytab file. Uses system default if not set.**NOTE**: This is not automatically used but must be added to the template in sasl.kerberos.kinit.cmd as ` ... -t %{sasl.kerberos.keytab}`. default: '' importance: low </summary>
        public string SaslKerberosKeytab { get => ConfluentConfig.SaslKerberosKeytab; set => ConfluentConfig.SaslKerberosKeytab = value; }

        ///<summary> Minimum time in milliseconds between key refresh attempts. default: 60000 importance: low </summary>
        public int? SaslKerberosMinTimeBeforeRelogin { get => ConfluentConfig.SaslKerberosMinTimeBeforeRelogin; set => ConfluentConfig.SaslKerberosMinTimeBeforeRelogin = value; }

        ///<summary> SASL username for use with the PLAIN and SASL-SCRAM-.. mechanisms default: '' importance: high </summary>
        public string SaslUsername { get => ConfluentConfig.SaslUsername; set => ConfluentConfig.SaslUsername = value; }

        ///<summary> SASL password for use with the PLAIN and SASL-SCRAM-.. mechanism default: '' importance: high </summary>
        public string SaslPassword { get => ConfluentConfig.SaslPassword; set => ConfluentConfig.SaslPassword = value; }

        ///<summary> List of plugin libraries to load (; separated). The library search path is platform dependent (see dlopen(3) for Unix and LoadLibrary() for Windows). If no filename extension is specified the platform-specific extension (such as .dll or .so) will be appended automatically. default: '' importance: low </summary>
        public string PluginLibraryPaths { get => ConfluentConfig.PluginLibraryPaths; set => ConfluentConfig.PluginLibraryPaths = value; }

        ///<summary> The maximum length of time (in milliseconds) before a cancellation request is acted on. Low values may result in measurably higher CPU usage. default: 100 range: 1 &lt;= dotnet.cancellation.delay.max.ms &lt;= 10000 importance: low </summary>
        public int CancellationDelayMaxMs { set => ConfluentConfig.CancellationDelayMaxMs = value; }
    }
}