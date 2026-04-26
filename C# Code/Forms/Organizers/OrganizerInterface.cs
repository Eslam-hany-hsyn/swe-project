using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_Form
{
    internal interface OrganizerInterface
    {
       

        #region FR 4 Full

        // status is appending by default
        // return true if it create else false
        int createEvent(int timeSlotID, int organizerID,string eventTitel, string descripation, DateTime date, int capacity);

        #endregion

        #region FR 5 Full

        // return true if it create else false
        bool cancelEvent(int eventID);

        // return true if it create else false

        bool updateEvent(int eventID, string eventTitel, string descripation, DateTime date, int capacity);

        #endregion

        #region FR 6 Partial

        // this should return all Time slots that available
        // each element is raw structured as :
        // "TimeSlotID,startTime,endtime,date" 
        string[] getAllAvailableTimeSlots();  // these will display to Organizer


        // this should return all Events for specific organizer that 
        // each element is raw structured as :
        // "eventid,title,description,date,startTime,endTime,capacity,status"
        string[] getAllEventsForOrganizer(int organizerID);

        #endregion

    }
}
