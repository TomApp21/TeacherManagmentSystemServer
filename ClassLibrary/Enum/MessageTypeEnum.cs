using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Enum
{
    public enum MessageTypeEnum
    {
            UserLoginRequestResponse, // Get a users details from the datatables. Requieres[email and password]
            ExchangePublicKeys, // Message containing the client/server public key. Requieres[public key]
            UpdateErrorLog, // Log a new error message. Requieres[ErrorLogDataModel]
            UpdateUserAudit, // Log a new user audit message. Requieres[UserAuditDataModel]
            GetUserNotifications, // Get a list of notification for the dashboard. Requieres[User id]
            GetUserList, // Get a list of all users known to the system
            GetClassesList, // Get a list of all classes known to the database
            GetClassesOrderedByStudents, // gets ordered classes list
            BroadcastNotification, // Chat messages have been update as a class has ended
            SendUserIdForServer, // Sends the user id to the server to tie the user to the connected client
            GetClassForPopup, // Get all the details needed for the class popup
            DeleteClass, // Delete the chosen class from the data file
            BroadcastMessageToClass, // Send a message to all parents that have students in the class
            GetParentSelectList, // Get a list of parent user data for a select list
            SaveJoinCodeForUserId, // Save this join code to the database
            GetJoinAuthenticationMessage, // Get athorization to join the class
            //ModifyClass, // Edit/Add a class. Requieres[ClassDataModel]
            //JoinClass, // Log a new student against a class. Requieres[ClassStudentDataModel],
            ClientConnection,
            CreateClass,
    }
     public enum _MessageTypes
        {

        }
}
