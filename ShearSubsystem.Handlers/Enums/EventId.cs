using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareSubsystem.Handlers.Enums
{
    public enum EventId
    {
        [Description("An event indicating the successful creation of a new resource.")]
        ResourceCreated = 1000,

        [Description("An event indicating the successful update of an existing resource.")]
        ResourceUpdated = 1001,

        [Description("An event indicating the successful deletion of a resource.")]
        ResourceDeleted = 1002,

        [Description("An event indicating that a resource retrieval operation was successful.")]
        ResourceRetrieved = 1003,

        [Description("An event indicating resource already updated.")]
        ResourceAlreadyUpdated = 1004,

        [Description("An event indicating resource not found.")]
        ResourceNotFound = 1005,

        [Description("An event indicating that a request was received.")]
        RequestReceived = 2000,

        [Description("An event indicating that a request processing has started.")]
        RequestProcessingStarted = 2001,

        [Description("An event indicating that a request processing has completed successfully.")]
        RequestProcessingCompleted = 2002,

        [Description("An event indicating that an error occurred during request processing.")]
        RequestProcessingError = 2003,

        [Description("An event indicating a successful user authentication.")]
        UserAuthenticated = 3000,

        [Description("An event indicating a user authorization failure.")]
        UserAuthorizationFailed = 3001,

        [Description("Input exceeds maximum allowed length")]
        lenght = 3002,

        [Description("html tag is not allowed input tag")]
        UserLoggedOut = 3003,

        [Description("An event indicating a validation error.")]
        ValidationError = 3004,

        [Description("An event indicating a system error occurred.")]
        SystemError = 4000,

        [Description("An event indicating a service is unavailable.")]
        ServiceUnavailable = 4001,

        [Description("An event indicating a configuration change.")]
        ConfigurationChanged = 5000,

        [Description("An event indicating a connection timeout to the database.")]
        DatabaseConnectionTimeout = 5001,

        [Description("An event indicating that the database operation failed.")]
        DatabaseOperationFailed = 5002,

        [Description("An event indicating that a transaction failed.")]
        DatabaseTransactionFailed = 5003,

        [Description("An event indicating a database error.")]
        DatabaseError = 5004,

        [Description("The Company is not registered in the System.")]
        DocumentNotFoundError = 5005,

        [Description("Can not insert duplicate Id in Database.")]
        DuplicateKeyFoundError = 5006,


        [Description("An event indicating a payment gateway service operation failure.")]
        PaymentGatewayServiceFailed = 7000,

        [Description("An event indicating an exception occurred during a payment gateway service operation.")]
        PaymentGatewayServiceException = 7002,

        [Description("Internal server error. Please contact support if the problem persists.")]
        InternalServerError = 9000,
    }
}
