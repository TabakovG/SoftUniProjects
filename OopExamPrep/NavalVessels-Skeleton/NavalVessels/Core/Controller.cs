using NavalVessels.Core.Contracts;
using NavalVessels.Models;
using NavalVessels.Models.Contracts;
using NavalVessels.Repositories;
using NavalVessels.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavalVessels.Core
{
    public class Controller : IController
    {
        private readonly VesselRepository vessels;
        private readonly List<ICaptain> captains;

        public Controller()
        {
            this.vessels = new VesselRepository();
            this.captains = new List<ICaptain>();
        }

        public string HireCaptain(string fullName)
        {
            bool captainExist = this.captains.Any(captains => captains.FullName == fullName);
            if (captainExist)
            {
                return String.Format(OutputMessages.CaptainIsAlreadyHired, fullName);
            }
            this.captains.Add(new Captain(fullName));
            return String.Format(OutputMessages.SuccessfullyAddedCaptain, fullName);
        }
        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            if (this.vessels.Models.Any(v => v.Name == name))
            {
                return String.Format(OutputMessages.VesselIsAlreadyManufactured, vesselType, name);
            }
            switch (vesselType)
            {
                case "Submarine":
                    this.vessels.Add(new Submarine(name, mainWeaponCaliber, speed));
                    break;
                case "Battleship":
                    this.vessels.Add(new Battleship(name, mainWeaponCaliber, speed));
                    break;
                default:
                    return OutputMessages.InvalidVesselType;
            }


            return String.Format(OutputMessages.SuccessfullyCreateVessel, vesselType, name, mainWeaponCaliber, speed);

        }
        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            var capt = this.captains.FirstOrDefault(c => c.FullName == selectedCaptainName);
            var vess = this.vessels.FindByName(selectedVesselName);

            if (capt == null)
            {
                return String.Format(OutputMessages.CaptainNotFound, selectedCaptainName);
            }
            else if (vess == null)
            {
                return String.Format(OutputMessages.VesselNotFound, selectedVesselName);
            }
            else if (vess.Captain != null)
            {
                return String.Format(OutputMessages.VesselOccupied, selectedVesselName);
            }

            capt.AddVessel(vess);
            vess.Captain = capt;

            return String.Format(OutputMessages.SuccessfullyAssignCaptain, selectedCaptainName, selectedVesselName);
        }
        public string CaptainReport(string captainFullName)
        {
            var capt = this.captains.FirstOrDefault(c => c.FullName == captainFullName);
            return capt == null ? String.Empty : capt.Report();
        }
        public string VesselReport(string vesselName)
        {
            var vess = this.vessels.FindByName(vesselName);
            return vess == null ? String.Empty : vess.ToString();
        }

        public string ToggleSpecialMode(string vesselName)
        {
            var vess = this.vessels.FindByName(vesselName);

            if (vess is Battleship bs)
            {
                bs.ToggleSonarMode();
                return String.Format(OutputMessages.ToggleBattleshipSonarMode, vesselName);
            }
            else if (vess is Submarine sbm)
            {
                sbm.ToggleSubmergeMode();
                return String.Format(OutputMessages.ToggleSubmarineSubmergeMode, vesselName);
            }

            return String.Format(OutputMessages.VesselNotFound, vesselName);

        }
        public string ServiceVessel(string vesselName)
        {
            var vess = this.vessels.FindByName(vesselName);
            if (vess == null)
            {
                return String.Format(OutputMessages.VesselNotFound, vesselName);
            }
            vess.RepairVessel();
            return String.Format(OutputMessages.SuccessfullyRepairVessel, vesselName);
        }
        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            var attackVessel = this.vessels.FindByName(attackingVesselName);
            var defVessel = this.vessels.FindByName(defendingVesselName);

            if (attackVessel == null || defVessel == null)
            {
                if (attackVessel == null)
                {
                    return String.Format(OutputMessages.VesselNotFound, attackingVesselName);
                }
                return String.Format(OutputMessages.VesselNotFound, defendingVesselName);

            }
            else if (attackVessel.ArmorThickness == 0 || defVessel.ArmorThickness == 0)
            {
                if (attackVessel.ArmorThickness == 0)
                {
                    return String.Format(OutputMessages.AttackVesselArmorThicknessZero, attackingVesselName);
                }
                return String.Format(OutputMessages.AttackVesselArmorThicknessZero, defendingVesselName);

            }

            attackVessel.Attack(defVessel);
            attackVessel.Captain.IncreaseCombatExperience();
            defVessel.Captain.IncreaseCombatExperience();
            return String.Format(OutputMessages.SuccessfullyAttackVessel, defendingVesselName, attackingVesselName, defVessel.ArmorThickness);
        }



    }
}
