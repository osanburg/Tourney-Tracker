using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles) 
        {
            if (database)
            {
                // TODO - set up the SQL connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            
            if (textFiles)
            {
                // TODO - set up the text file connector
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
