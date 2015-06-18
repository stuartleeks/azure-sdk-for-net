// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing pipeline runs.
    /// </summary>
    public partial interface IPipelineRunOperations
    {
        /// <summary>
        /// Gets the first page of runs of an activity in the pipeline over a
        /// time range with the link to the next page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='pipelineName'>
        /// A unique pipeline instance name
        /// </param>
        /// <param name='parameters'>
        /// Parameters required to get the runs of a pipeline.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The GetRuns pipeline operation response.
        /// </returns>
        Task<PipelineRunListResponse> ListAsync(string resourceGroupName, string dataFactoryName, string pipelineName, PipelineRunListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of pipeline runs with the link to the next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next pipeline runs page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The GetRuns pipeline operation response.
        /// </returns>
        Task<PipelineRunListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}