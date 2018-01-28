using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GenericMethodUsingImplicitTyping.DelegateDictionary
{
    public enum Action
    {
        Save,
        Back,
        Next,
        Forward
    }

    public class RemovalOfIfElseController
    {
        private Dictionary<Action, Func<UserData, ActionResult>> actionMapper;

        public RemovalOfIfElseController()
        {
            actionMapper = new Dictionary<Action, Func<UserData, ActionResult>>();
            actionMapper.Add(Action.Save, SaveOperation);
            actionMapper.Add(Action.Back, BackOperation);
            actionMapper.Add(Action.Next, NextOperation);
            actionMapper.Add(Action.Forward, ForwardOperation);
        }

        private ActionResult SaveOperation(UserData data)
        {
            return new ActionResult(Action.Save);
        }

        private ActionResult NextOperation(UserData data)
        {
            return new ActionResult(Action.Next);
        }

        private ActionResult BackOperation(UserData data)
        {
            return new ActionResult(Action.Back);
        }

        private ActionResult ForwardOperation(UserData data)
        {
            return new ActionResult(Action.Forward);
        }

        /// <summary>
        /// This is the old way of acheiving it 
        /// </summary>
        /// <param name="whichButton"></param>
        /// <param name="userData"></param>
        /// <returns></returns>
        public ActionResult TheActionPart1(string whichButton, UserData userData)
        {
            ActionResult actionMapper = default(ActionResult);

            if(whichButton == Action.Save.ToString())
            {
               actionMapper = SaveOperation(userData);
            }
            if (whichButton == Action.Back.ToString())
            {
                actionMapper = BackOperation(userData);
            }
            if (whichButton == Action.Next.ToString())
            {
                actionMapper = NextOperation(userData);
            }
            else
            {
                actionMapper = ForwardOperation(userData);
            }

            return actionMapper;

        }

        /// <summary>
        /// This is the way we can perform using delegate dictionary
        /// </summary>
        /// <param name="whichButton"></param>
        /// <param name="userData"></param>
        public ActionResult TheActionPart2(Action whichButton, UserData userData)
        {

            if (actionMapper.ContainsKey(whichButton))
            {
                 return actionMapper[whichButton](userData);
            }

            else
            {
                throw new NotImplementedException();
            }
        }
    }

    public class ActionResult
    {
        public ActionResult(Action actionName)
        {
            Debug.WriteLine($"Performing {actionName} operation");
        }
    }

    public class UserData
    {
        public UserData()
        {
                
        }
    }
}
