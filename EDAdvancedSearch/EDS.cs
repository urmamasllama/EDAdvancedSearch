using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
    public static class EDS
    {
        public static DateTime FromUnixTime(this long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        //this version of prep is used when you want to specify a file path for a json file to use
        public static List<SysObj> Prep(String path)
        {
            List<SysObj> systems = new List<SysObj>();
            if (File.Exists(path))
            {
                JArray list = JArray.Parse(File.ReadAllText(path));
                SysObj sys = null;
                var setting = new JsonSerializerSettings();
                setting.NullValueHandling = NullValueHandling.Ignore;                
                List<SysObj> result = new List<SysObj>();

                for (int cnt = 0; cnt < list.Count; cnt++)
                {
                    sys = JsonConvert.DeserializeObject<SysObj>(list[cnt].ToString(), setting);
                    if (string.IsNullOrEmpty(sys.security))
                        sys.security = "None";
                    if (string.IsNullOrEmpty(sys.power))
                        sys.power = "None";
                    if (string.IsNullOrEmpty(sys.primary_economy))
                        sys.primary_economy = "None";
                    if (string.IsNullOrEmpty(sys.simbad_ref))
                        sys.simbad_ref = "";
                    if (string.IsNullOrEmpty(sys.power_state))
                        sys.power_state = "None";
                    if (string.IsNullOrEmpty(sys.state))
                        sys.state = "None";
                    if (string.IsNullOrEmpty(sys.allegiance))
                        sys.allegiance = "None";
                    if (string.IsNullOrEmpty(sys.government))
                        sys.government = "None";
                    if (string.IsNullOrEmpty(sys.faction))
                        sys.faction = "None";
                    if (sys.needs_permit.Equals(null))
                        sys.needs_permit = 0;
                    systems.Add(sys);
                }
            }
            else systems = null;
            return systems;
        }
        public static List<SysObj> Prep(JArray list)
        {
            SysObj sys = null;
            var setting = new JsonSerializerSettings();
            setting.NullValueHandling = NullValueHandling.Ignore;
            List<SysObj> systems = new List<SysObj>();
            List<SysObj> result = new List<SysObj>();
            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                sys = JsonConvert.DeserializeObject<SysObj>(list[cnt].ToString(), setting);
                if (string.IsNullOrEmpty(sys.security))
                    sys.security = "None";
                if (string.IsNullOrEmpty(sys.power))
                    sys.power = "None";
                if (string.IsNullOrEmpty(sys.primary_economy))
                    sys.primary_economy = "None";
                if (string.IsNullOrEmpty(sys.simbad_ref))
                    sys.simbad_ref = "";
                if (string.IsNullOrEmpty(sys.power_state))
                    sys.power_state = "None";
                if (string.IsNullOrEmpty(sys.state))
                    sys.state = "None";
                if (string.IsNullOrEmpty(sys.allegiance))
                    sys.allegiance = "None";
                if (string.IsNullOrEmpty(sys.government))
                    sys.government = "None";
                if (string.IsNullOrEmpty(sys.faction))
                    sys.faction = "None";
                if (sys.needs_permit.Equals(null))
                    sys.needs_permit = 0;
                systems.Add(sys);
            }
            return systems;
        }

        //this prep overload is used to pull from https://eddb.io/archive/v4/systems.json once daily to keep the local file up to date
        public static List<SysObj> Prep()
        {
            DateTime now = DateTime.Now;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"\EDAdvS\EDDBSYS" + now.ToString("MM-dd-yyyy") + ".json");
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"\EDAdvS");
            if (!File.Exists(path))//used to avoid having a bunch of older versions of the file
            {
                if (Directory.Exists(folder))                
                    Directory.Delete(folder, true);
                                    
                Directory.CreateDirectory(folder);
                WebClient Client = new WebClient();
                Client.DownloadFile("https://eddb.io/archive/v4/systems.json", path);
            }

            return Prep(path);
        }
        /* json pulled from https://eddb.io/archive/v4/systems.json
         * Query-able items:
         * id     should be internal only
         * name    name of the system
         * x y z    coordinates pass a rad value for radius from target always pass at least 0 for rad
         * faction    dominant faction of the system
         * population    total population
         * government    government type
         * allegiance    who the system is allied with Federation , Empire, Alliance, Independent
         * state         seems to always be null not sure what it is
         * security      security level None, Low, Medium, High
         * primary_economy    main economy of system
         * power          power play character controlling the system
         * power_state    Control or Exploited
         * needs_permit   if you need a permit to jump to it use 0 or 1
         * updated_at     time of last update
         * simbad_ref     seems to be the same as name don't know what its for
         * if(list[cnt][].Equals() || list[cnt][].Equals(null))
         */
        //if you don't want to search for something pass it as null
        public static List<SysObj> Search(int? id, string name, float? x, float? y, float? z, float? rad, string faction, long? popMin, long? popMax, string government, string allegiance,
            string state, string security, string primary_economy, string power, string power_state, int? needs_permit, string simbad_ref)
        {
            List<SysObj> list = Prep();
            List<SysObj> sys = Search(list, id, name, x, y, z, rad, faction, popMin, popMax, government, allegiance,
                    state, security, primary_economy, power, power_state, needs_permit, simbad_ref);
         
            return sys;
        }
        public static List<SysObj> Search(SysObj s, float? rad, long? popMin, long? popMax) //overload to take a SysObj for most pertinent items and use local json list
        {
            List<SysObj> sys = Search(s.id, s.name, s.x, s.y, s.z, rad, s.faction, popMin, popMax, s.government, s.allegiance,
                s.state, s.security, s.primary_economy, s.power, s.power_state, s.needs_permit, s.simbad_ref);
            return sys;
        }

        public static List<SysObj> Search(List<SysObj> list, SysObj s, float? rad, long? popMin, long? popMax) //overload to take a SysObj for most pertinent items and use provided json list
        {
            List<SysObj> sys = Search(list, s.id, s.name, s.x, s.y, s.z, rad, s.faction, popMin, popMax, s.government, s.allegiance,
                s.state, s.security, s.primary_economy, s.power, s.power_state, s.needs_permit, s.simbad_ref);
            return sys;
        }

        public static List<SysObj> Search(JArray list, SysObj s, float? rad, long? popMin, long? popMax) //overload to take a SysObj for most pertinent items and use external json list
        {
            List<SysObj> sys = Search(list, s.id, s.name, s.x, s.y, s.z, rad, s.faction, popMin, popMax, s.government, s.allegiance,
                s.state, s.security, s.primary_economy, s.power, s.power_state, s.needs_permit, s.simbad_ref);
            return sys;
        }

        //overload for externally provided list
        public static List<SysObj> Search(JArray list, int? id, string name, float? x, float? y, float? z, float? rad, string faction, long? popMin, long? popMax, string government, string allegiance,
            string state, string security, string primary_economy, string power, string power_state, int? needs_permit, string simbad_ref)
        {

            List<SysObj> systems = Prep(list);
            List<SysObj> result = Search(systems,id,name,x,y,z,rad,faction,popMin,popMax,government,allegiance,state,security,primary_economy,power,power_state,needs_permit,simbad_ref);
            return result;
        }
        
        //primary Search runtime method
        public static List<SysObj> Search(List<SysObj> systems, int? id, string name, float? x, float? y, float? z, float? rad, string faction, long? popMin, long? popMax, string government, string allegiance,
            string state, string security, string primary_economy, string power, string power_state, int? needs_permit, string simbad_ref)
        {
            
            List<SysObj> result = new List<SysObj>();
            for (int cnt = 0; cnt < systems.Count; cnt++)
            {
                if (id.Equals(null) || systems[cnt].id.Equals(id))
                {//id check
                    if (string.IsNullOrEmpty(name) || systems[cnt].name.Contains(name))
                    {//name check
                        if (x.Equals(null) || ((systems[cnt].x <= (x + rad)) && (systems[cnt].x >= (x - rad))))
                        {//x coord check
                            if (y.Equals(null) || ((systems[cnt].y <= (y + rad)) && (systems[cnt].y >= (y - rad))))
                            {// y coord check
                                if (z.Equals(null) || ((systems[cnt].z <= (z + rad)) && (systems[cnt].z >= (z - rad))))
                                {//z coord check
                                    if (string.IsNullOrEmpty(faction) || systems[cnt].faction.Contains(faction))
                                    {
                                        //if (string.IsNullOrEmpty(faction)) Console.WriteLine("passed by null!");
                                        if ((popMin.Equals(null) || popMax.Equals(null)) || ((systems[cnt].population <= popMax) && (systems[cnt].population >= popMin)))
                                        {//pop check
                                            if (string.IsNullOrEmpty(government) || systems[cnt].government.Equals(government))
                                            {// government check
                                                //if (string.IsNullOrEmpty(government))  MessageBox.Show("passed by null!");
                                                if (string.IsNullOrEmpty(allegiance) || systems[cnt].allegiance.Equals(allegiance))
                                                {//allegiance check
                                                    if (string.IsNullOrEmpty(state) || systems[cnt].state.Equals(state))
                                                    {//state check
                                                        if (string.IsNullOrEmpty(security) || systems[cnt].security.Equals(security))
                                                        {//security check
                                                            if (string.IsNullOrEmpty(primary_economy) || systems[cnt].primary_economy.Equals(primary_economy))
                                                            {//primary economy check
                                                                if (string.IsNullOrEmpty(power) || systems[cnt].power.Equals(power))
                                                                {//power check
                                                                    if (string.IsNullOrEmpty(power_state) || systems[cnt].power_state.Equals(power_state))
                                                                    {//power state check
                                                                        if (needs_permit.Equals(null) || systems[cnt].needs_permit.Equals(needs_permit))
                                                                        {//permit check                                                                        
                                                                            if (string.IsNullOrEmpty(simbad_ref) || systems[cnt].simbad_ref.Equals(simbad_ref))//simbad ref check
                                                                            {
                                                                                SysObj sys = systems[cnt];
                                                                                result.Add(sys);
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
