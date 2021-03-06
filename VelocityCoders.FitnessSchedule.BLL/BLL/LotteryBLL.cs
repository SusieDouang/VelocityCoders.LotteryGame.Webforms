﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.LotteryGame.Models;
using VelocityCoders.LotteryGame.Models.Enums;
using VelocityCoders.LotteryGame.Models.Collections;
using VelocityCoders.LotteryGame.DAL;

namespace VelocityCoders.LotteryGame.BLL
{
    public static class LotteryBLL
    {
        #region GET ITEM

        public static Lottery GetItem(int lotteryId)
        {
            return LotteryDAL.GetItem(lotteryId);
        }

        #endregion

        #region GET COLLECTION

        public static LotteryCollection GetCollection(LotteryEnum lotteryName)
        {
            LotteryCollection collection = LotteryDAL.GetCollection(lotteryName);
            return collection;
        }
        #endregion

        #region INSERT, UPDATE
        
        public static int Save(Lottery lotterytoSave)
        {
            int returnValue;
            returnValue = LotteryDAL.Save(lotterytoSave);

            return returnValue;
        }
        #endregion

        #region DELETE
        public static bool Delete(int lotteryId)
        {
            //notes: call DAL to delete lottery record
            return LotteryDAL.Delete(lotteryId);
        }
        #endregion
    }
}