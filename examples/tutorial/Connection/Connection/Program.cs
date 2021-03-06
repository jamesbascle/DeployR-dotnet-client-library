﻿/*
 * Program.cs
 *
 * Copyright (C) 2010-2015 by Microsoft Corporation
 *
 * This program is licensed to you under the terms of Version 2.0 of the
 * Apache License. This program is distributed WITHOUT
 * ANY EXPRESS OR IMPLIED WARRANTY, INCLUDING THOSE OF NON-INFRINGEMENT,
 * MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE. Please refer to the
 * Apache License 2.0 (http://www.apache.org/licenses/LICENSE-2.0) for more details.
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeployR;

namespace Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // 1. Establish a connection to DeployR.
            //
            // This example assumes the DeployR server is running on localhost.
            //
            String deployrEndpoint = "http://localhost:7400/deployr";
            RClient rClient = RClientFactory.createClient(deployrEndpoint);
        }
    }
}
