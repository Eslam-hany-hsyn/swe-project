using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Form
{
    internal interface AdminInterface
    {

        #region FR 7 Full 

        // return true if it create else false
        bool createTimeSlots(int admminID, DateTime date,string startTime, string endTime);
       
        #endregion


        #region FR 8 Partial

        // display all appending events to admin to (Approve/Deny) request of event
        string[] getAllAppendingEvent();


        // update Event Status after admin (Approve/Deny) 
        // return true if it update else false
        bool updateEventStatus(int eventID, string status);

        #endregion


        #region FR 8 Partial and 9 Full

        // this should return all event titles that coming after admin approved 
        // the data coming from admin.
        // Hint: read Source of Functional Requirement 9 
        string[] getAllApprovedEventTitles();

        string[] getAllTimeSlots();

        #endregion

    }
}
