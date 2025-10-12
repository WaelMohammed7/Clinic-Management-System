using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystemDataAccess
{
    public class clsclsEventLog
    {
        public static void LogOrCreateEventSoures(string Message)
        {
            string SoureName = "ClinicManagementSystem";

            if (!EventLog.SourceExists(SoureName))
            {
                EventLog.CreateEventSource(SoureName, "Application");
            }

            EventLog.WriteEntry(SoureName, Message, EventLogEntryType.Error);

        }
    }
}
