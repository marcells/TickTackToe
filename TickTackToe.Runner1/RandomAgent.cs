﻿using System;
using TickTackToe.Agent;
using TickTackToe.Game;

namespace TickTackToe.Runner
{
    class RandomAgent : IAgent
    {
        public Move GetNextMove(Status status)
        {
            var random = new Random();
            return new Move(random.Next(3), random.Next(3));
        }

        public void Observe(Status oldStatus, Status currentStatus, MoveResult moveResult, Move move)
        {
        }
    }
}