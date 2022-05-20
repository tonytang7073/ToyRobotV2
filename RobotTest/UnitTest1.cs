using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotMoving;

namespace RobotTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Case1()
        //{
        //    string expectoutput = "0,1,NORTH";
        //    Robot a = new Robot();

        //    a.RunConsoleCommand(RobotCommand.PLACE, "0,0,NORTH");
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.REPORT, null);


        //    Assert.AreEqual(expectoutput, a.Report());


        //}

        //[TestMethod]
        //public void Case2()
        //{
        //    string expectoutput = "0,0,WEST";
        //    Robot a = new Robot();

        //    a.RunConsoleCommand(RobotCommand.PLACE, "0,0,NORTH");
        //    a.RunConsoleCommand(RobotCommand.LEFT, null);
        //    a.RunConsoleCommand(RobotCommand.REPORT, null);


        //    Assert.AreEqual(expectoutput, a.Report());


        //}

        //[TestMethod]
        //public void Case3()
        //{
        //    string expectoutput = "3,3,NORTH";
        //    Robot a = new Robot();

        //    a.RunConsoleCommand(RobotCommand.PLACE, "1,2,EAST");
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.LEFT, null);
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.REPORT, null);


        //    Assert.AreEqual(expectoutput, a.Report());


        //}

        //[TestMethod]
        //public void Case4()
        //{
        //    string expectoutput = "3,2,NORTH";
        //    Robot a = new Robot();

        //    a.RunConsoleCommand(RobotCommand.PLACE, "1,2,EAST");
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.LEFT, null);
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.PLACE, "3,1");
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.REPORT, null);


        //    Assert.AreEqual(expectoutput, a.Report());


        //}

        //[TestMethod]
        //public void Case5()
        //{
        //    string expectoutput = "1,3,NORTH";
        //    Robot a = new Robot();

        //    a.RunConsoleCommand(RobotCommand.PLACE, "1,2,EAST");
        //    a.RunConsoleCommand(RobotCommand.AVOID, "2,2");
        //    a.RunConsoleCommand(RobotCommand.AVOID, "2,3");
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.PLACE, "2,3");
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.LEFT, null);
        //    a.RunConsoleCommand(RobotCommand.MOVE, null);
        //    a.RunConsoleCommand(RobotCommand.REPORT, null);


        //    Assert.AreEqual(expectoutput, a.Report());


        //}

        [TestMethod]
        public void CaseA()
        {
            string expectoutput = "1,1,NORTH EAST";
            Robot a = new Robot();

            a.RunConsoleCommand(RobotCommand.PLACE, "0,0,NORTH");
            a.RunConsoleCommand(RobotCommand.RIGHT, null);
            a.RunConsoleCommand(RobotCommand.MOVE, null);
            a.RunConsoleCommand(RobotCommand.REPORT, null);


            Assert.AreEqual(expectoutput, a.Report());


        }

        [TestMethod]
        public void CaseB()
        {
            string expectoutput = "0,2,WEST";
            Robot a = new Robot();

            a.RunConsoleCommand(RobotCommand.PLACE, "2,3,SOUTH WEST");
            a.RunConsoleCommand(RobotCommand.MOVE, null);
            a.RunConsoleCommand(RobotCommand.RIGHT, null);
            a.RunConsoleCommand(RobotCommand.MOVE, null);
            a.RunConsoleCommand(RobotCommand.REPORT, null);


            Assert.AreEqual(expectoutput, a.Report());


        }

        [TestMethod]
        public void CaseC()
        {
            string expectoutput = "2,3,NORTH EAST";
            Robot a = new Robot();

            a.RunConsoleCommand(RobotCommand.PLACE, "1,2,EAST");
            a.RunConsoleCommand(RobotCommand.AVOID, "2,2");
            a.RunConsoleCommand(RobotCommand.AVOID, "1,3");
            a.RunConsoleCommand(RobotCommand.MOVE, null);
            a.RunConsoleCommand(RobotCommand.LEFT, null);
            a.RunConsoleCommand(RobotCommand.MOVE, null);
            a.RunConsoleCommand(RobotCommand.REPORT, null);


            Assert.AreEqual(expectoutput, a.Report());


        }

    }
}
