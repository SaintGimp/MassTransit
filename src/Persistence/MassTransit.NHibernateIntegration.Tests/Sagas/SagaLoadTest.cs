// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.NHibernateIntegration.Tests.Sagas
{
	using MassTransit.Tests.TextFixtures;
	using NUnit.Framework;

	[TestFixture, Category("Integration")]
	public class SagaLoadTest :
		LoopbackTestFixture
	{
		[Test]
		public void Put_some_stress_on_the_saga_dispatcher_to_see_how_it_handles_multiple_sagas_at_once()
		{
		}
	}
}