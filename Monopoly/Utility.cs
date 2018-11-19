using System;

namespace Monopoly
{
    /// <summary>
    /// Type of property such as water works
    /// </summary>
    [Serializable]
    public class Utility : TradableProperty
    {
        static int rentMultiplier = 6; //factor to multiply times roll of dice to getRent

        public Utility() : this("Utility"){}

        public Utility(String name)
        {
            this.sName = name;
            this.owner = Banker.access();
        }

        public override string ToString()
        {
           return base.ToString() + string.Format("\t{0,12}", this.IsMortgaged ? "Mortgaged" : "Unmortgaged");
        }
        public override void payRent(ref Player player)
        {
            player.pay(this.getRent(ref player));
            
            this.getOwner().receive(this.getRent(ref player));
        }

        public decimal getRent(ref Player player)
        {
            return (rentMultiplier * player.getLastMove());
        }

        public override string landOn(ref Player player)
        {
            //Pay rent if needed
            if ((this.getOwner() != Banker.access()) && (this.getOwner() != player))
            {
                //pay rent
                this.payRent(ref player);
                return string.Format("You landed on a Utility and  rolled a total of {0}. So your rent is {0} x {1} = ${2}.", player.getLastMove(), Utility.rentMultiplier, (player.getLastMove() * Utility.rentMultiplier));
            }
            else
                return base.landOn(ref player);
        }
    }
    
}
