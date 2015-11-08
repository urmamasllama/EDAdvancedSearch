/*  ED Advanced Search is a third party search tool for Elite:Dangerous
 *  Copyright (C) 2015  Benjamin Massingill
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *  Elite:Dangerous is Property of Frontier Developments http://www.frontier.co.uk/
 *  Json.net is property of NewtonSoft http://www.newtonsoft.com
 *  Json files sourced from https://eddb.io/archive/v4/systems.json
 *  Some code sourced from MSDN https://msdn.microsoft.com/en-us/library/ms229644(v=vs.90).aspx
 *  some code sourced from stackoverflow http://stackoverflow.com/
 */
namespace EDAdvancedSearch
{
    public class SysObj
    {
        public SysObj()
        {

        }
        public SysObj(int i, string nm, float xc, float yc, float zc, string fc, long pop, string gov,
            string all, string st, string sec, string pec, string pow, string powst, int perm, long upd, string sim)
        {
            id = i;
            name = nm;
            x = xc;
            y = yc;
            z = zc;
            faction = fc;
            population = pop;
            government = gov;
            allegiance = all;
            state = st;
            security = sec;
            primary_economy = pec;
            power = pow;
            power_state = powst;
            needs_permit = perm;
            updated_at = upd;
            simbad_ref = sim;
        }
        public int? id { get; set; }
        public string name { get; set; }
        public float? x { get; set; }
        public float? y { get; set; }
        public float? z { get; set; }
        public string faction { get; set; }
        public long? population { get; set; }
        public string government { get; set; }
        public string allegiance { get; set; }
        public string state { get; set; }
        public string security { get; set; }
        public string primary_economy { get; set; }
        public string power { get; set; }
        public string power_state { get; set; }
        public int? needs_permit { get; set; }
        public long? updated_at { get; set; }
        public string simbad_ref { get; set; }
    }
}
