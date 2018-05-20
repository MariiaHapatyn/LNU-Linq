using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqStart {
    class Client {
        public int ID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Hours { get; set; }

        public static Client MinDuration ( List<Client> arr ) {
            var result = arr.Aggregate( ( x1, x2 ) => x1.Hours < x2.Hours ? x1 : x2 );
            return result;
        }

        public static Client MaxDuration ( List<Client> arr ) {
            var result = arr.Aggregate( ( x1, x2 ) => x1.Hours > x2.Hours ? x1 : x2 );
            return result;
        }

        public static int YearWithMaxDuration ( List<Client> arr ) {
            var grouped = arr.GroupBy( x => x.Year ).Select( g => new { Name = g.Key, Sum = g.Sum( x => x.Hours ) } );

            var result = grouped.OrderBy( x => x.Name ).Aggregate( ( x1, x2 ) => x1.Sum > x2.Sum ? x1 : x2 ).Name;
            return result;
        }

        public static IOrderedEnumerable<KeyValuePair<int, int>> ClientSumHours ( List<Client> arr ) {
            Dictionary<int, int> sumHours = new Dictionary<int, int>();

            var grouped = arr.GroupBy( x => x.ID ).Select( g => new { Name = g.Key, Sum = g.Sum( x => x.Hours ) } );

            foreach( var i in grouped ) {
                sumHours.Add( i.Name, i.Sum );
            }

            var result = sumHours.OrderByDescending( x => x.Value );
            return result;
        }

        public static List<KeyValuePair<int, int>> TotalMonthNum ( List<Client> arr ) {

            var clients = arr.Select( x => new KeyValuePair<int, int>( x.ID, arr.Count( y => y.ID == x.ID ) ) ).Distinct().OrderBy( x => x.Key ).ToList();
            return clients;
        }
    }
}
