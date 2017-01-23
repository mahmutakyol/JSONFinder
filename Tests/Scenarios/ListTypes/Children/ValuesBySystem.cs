using Repositories.Lists;
using Tests.Core;

namespace Tests.Scenarios.ListTypes.Children
{
    class ListTypeChildrenValuesBySystem : TestDecorator
    {

        public override string GetName()
        {
            return "namespace => " + this.GetType().Namespace + ", class => " + this.GetType().Name;
        }

        public override void Execute()
        {
            SystemListValue city = new SystemListValue();
            SystemListValue country = new SystemListValue();
            SystemListValue region = new SystemListValue();
            SystemListValue district = new SystemListValue();
            FilteredList filteredList = new FilteredList();
            GetChildrenValuesBySystem value = new GetChildrenValuesBySystem()
            {
                city = city,
                country = country,
                district = district,
                region = region,
                filteredLists =
                {
                    filteredList
                },
                langId = 1,
                mainQuery = "mainQuery"

            };

            HTTP.Name("List Type Values Children ValuesBySystem Testi")
                .Post("api/listTypes/children/valuesBySystem", value)
                .ShouldBeOk();
        }
    }
}
