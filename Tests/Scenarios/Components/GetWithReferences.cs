﻿using Repositories.HTTP.Requests.Components;
using Tests.Core;

namespace Tests.Scenarios.Components
{
    class ComponentsGetWithReferences : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            GetWithReferences get = new GetWithReferences()
            {
                code = "code",
                current = 0,
                name = "name",
                referenceId = 1
            };

            HTTP.Name("Component GetWithRegerences Testi")
                .Post("api/componentsWithReferences", get)
                .ShouldBeOk();
        }
    }
}
