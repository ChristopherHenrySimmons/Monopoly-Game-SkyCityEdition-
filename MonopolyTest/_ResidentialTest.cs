using NUnit.Framework;
using Monopoly;

namespace MonopolyTest
{
    class _ResidentialTest
    {
        [Test]
        public void TestConstructor()
        {
            Residential r = new Residential();
            Assert.Greater( r.ToString().Length,0);
        }
        [Test]
        public void TestGet()
        {
            Residential r = new Residential();
            Assert.AreEqual(50, r.getHouseCost());
            Assert.AreEqual(60, r.getHotelCost());

            Assert.AreEqual(0, r.getHouseCount());
            Assert.AreEqual(50, r.getRent());
            Assert.AreEqual(200, r.getPrice());
            Assert.AreEqual(4, Residential.getMaxHouses());
            Assert.AreEqual(1, Residential.getMaxHotels());

        }
        [Test]
        public void TestAddAndReducehouse()
        {
            Residential r = new Residential();
            Player p = new Player("Tom",1000);
            r.setOwner(ref p);
            r.addHouse();
            Assert.AreEqual(1, r.getHouseCount());
            r.reduceHouse();
            Assert.AreEqual(0, r.getHouseCount());

        }
        [Test]
        public void TestAddAndReducehotel()
        {
            Residential r = new Residential();
            Player p = new Player("Tom", 1000);
            r.setOwner(ref p);
            r.addHotel();
            Assert.AreEqual(1, r.getHotelCount());
            r.reduceHotel();
            Assert.AreEqual(0, r.getHotelCount());

        }

    }
}
