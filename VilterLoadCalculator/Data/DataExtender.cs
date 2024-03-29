﻿using SQLite;
using VilterLoadCalculator.Models;

namespace VilterLoadCalculator.Data
{
    public static class DataExtender
    {
        public static string DataBaseNameAndPath = "VilterLoadEstimator.db";

        public static void CreateProgramTables()
        {
            var db = new SQLiteConnection(DataBaseNameAndPath);
            db.CreateTable<BlastFreezingLoadEstimates>();
        }
    }

}
