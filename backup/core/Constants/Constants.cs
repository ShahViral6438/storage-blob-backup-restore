﻿// 
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
using System;
using System.Collections.Generic;
using System.Text;

/**
 * Description:
 * This class defines constant values used by the backup and restore applications/Functions.
 * 
 * Author: GR @Microsoft
 * Dated: 05-23-2020
 *
 * NOTES: Capture updates to the code below.
 */
namespace backup.core.Constants
{
    public class Constants
    {
        /// <summary>
        /// BLOB Event Type
        /// </summary>
        public struct BlobEventType
        {
            public const string BLOBCREATED = "Microsoft.Storage.BlobCreated";
            public const string BLOBDELETED = "Microsoft.Storage.BlobDeleted";
        }

	/// <summary>
	/// Input constants used in the request values of the Restore process
	/// </summary>
        public struct RestoreReqInputs
        {
            public const string YES = "YES";
            public const string NO = "NO";
	}
    }
}