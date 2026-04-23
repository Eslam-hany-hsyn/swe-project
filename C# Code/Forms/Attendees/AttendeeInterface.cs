using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Form
{
    internal interface AttendeeInterface
    {

        #region FR 2 Full

        // this fun should return array of string such that
        // the each element is raw structured as :
        // if Attendee is not Register or Withdraw yet then "eventID,OrganizerName,title,description,eventTime,eventStatus,Capacity"  [is New Event]
        // else "eventID,OrganizerName,title,Description,eventTime,eventStatus,Capacity,attendeeStatus"  
        string[] Filter_Results(string title, DateTime startDate, DateTime endDate);

        #endregion

        #region FR 3 Full

        // this function update status of Attendee
        // input status equal "register" or "cancel"
        void RegisterOrCancellation(int eventID,int attendeeID,string status);

        #endregion


        #region FR 6 Partial

        // this should return all event that approved by admin
        //  each element is raw structured as :
        //  "EventID,title,description,eventdate,eventTime,eventStatus,Capacity,attendeeStatus" 
        string[] getAllApprovedEvent();  // these will display to Attendee

        #endregion


        
    }
}
