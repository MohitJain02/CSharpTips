using Xunit;

namespace GenericMethodUsingImplicitTyping.DelegateDictionary
{
    public class DelegateDictionaryTests
    {
        private readonly DelegateDictionaryController controller;
        private readonly RemovalOfIfElseController removalController;

        public DelegateDictionaryTests()
        {
            controller = new DelegateDictionaryController();
            removalController = new RemovalOfIfElseController();
            
        }
        [Fact]
        public void DelegateDictionaryControllerTest()
        {
            var actionMapperDic = controller.DelegateMapperFunc();
            var resultFromFunc1 = actionMapperDic["Func1"].DynamicInvoke(new object[] { 4 });
            var resultFromFunc2 = actionMapperDic["Func2"].DynamicInvoke(new object[] { "Mohit" });
            var resultFromFunc3 = actionMapperDic["Func3"].DynamicInvoke(null);



            Assert.Equal("This is Func1: 4", resultFromFunc1);
            Assert.Equal("This is Func2: Mohit", resultFromFunc2);
            Assert.Equal(2, resultFromFunc3);

        }

        [Fact]
        public void RemovalOfIfElseStatementTest()
        {
            var actionMapperDicFromLongWay = removalController.TheActionPart1(Action.Save.ToString(), new UserData());

            var saveResult = removalController.TheActionPart2(Action.Save, new UserData());
            var backResult = removalController.TheActionPart2(Action.Back, new UserData());
            var nextResult = removalController.TheActionPart2(Action.Next, new UserData());
            var forwardResult = removalController.TheActionPart2(Action.Forward, new UserData());
        }

    }
}
