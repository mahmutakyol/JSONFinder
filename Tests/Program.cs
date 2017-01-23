using System;
using System.Collections.Generic;
using Tests.Interfaces;
using Tests.Scenarios.Auth;
using Tests.Scenarios.Components.Styles;
using Tests.Scenarios.Components;
using Tests.Scenarios.Externals.Parameters;
using Tests.Scenarios.Forms;
using Tests.Scenarios.Forms.Design;
using Tests.Scenarios.Forms.Formulas;
using Tests.Scenarios.LangValues.Components;
using Tests.Scenarios.LangValues.General;
using Tests.Scenarios.LangValues.Lists;
using Tests.Scenarios.LangValues.ListValues;
using Tests.Scenarios.LangValues.SystemDates;
using Tests.Scenarios.LangValues.Wizards;
using Tests.Scenarios.Lists.Filter;
using Tests.Scenarios.Lists.FilterConnections;
using Tests.Scenarios.Lists.System.City;
using Tests.Scenarios.Lists.System.Country;
using Tests.Scenarios.Lists.System.District;
using Tests.Scenarios.Lists.System.Language;
using Tests.Scenarios.Lists.System.Region;
using Tests.Scenarios.Logs;
using Tests.Scenarios.Managers;
using Tests.Scenarios.Menus;
using Tests.Scenarios.Table.Component;
using Tests.Scenarios.Table.Component.RefactorReports;
using Tests.Scenarios.Table.RefactorReports;
using Tests.Scenarios.Wizards.Fields.Conditions;
using Tests.Scenarios.Wizards.Fields.Rules;
using Tests.Scenarios.Wizards.Fields.Validations;
using Tests.Scenarios.Wizards.List;
using Tests.Scenarios.Wizards.Previews;
using Tests.Scenarios.Externals.Definitions;
using Tests.Scenarios.Table;
using Tests.Scenarios.Wizards;
using Tests.Scenarios.Languages;
using Tests.Scenarios.ListTypes.Children;
using Tests.Scenarios.ListTypes.Values;
using Tests.Scenarios.ListTypes;
using Tests.Scenarios.References;
using Tests.Scenarios.Relationships;
using Tests.Scenarios.Services;
using System.Threading;
using Tests.Scenarios;
using Tests.Scenarios.Wizards.Fields;
using Tests.Scenarios.Table.Posts;
using Tests.Scenarios.Components.Creates;
using Tests.Scenarios.Table.Component.Creates;
using Tests.Scenarios.Wizards.Posts;
using Tests.Scenarios.Forms.Creates;
using Tests.Scenarios.Table.Component.Creates.Authors;
using Tests.Scenarios.Table.Component.Creates.Books;
using Tests.Scenarios.Table.Component.Creates.Rents;
using Tests.Scenarios.Table.Component.Creates.Users;
using Tests.Scenarios.Table.Deletes;
using Tests.Scenarios.Wizards.Fields.Adds;
using Tests.Scenarios.Wizards.Deletes;
using Tests.Scenarios.Forms.Design.AddWizards;
using Tests.Scenarios.Forms.Design.RemoveWizards;
using Tests.Scenarios.Forms.Deletes;
using Tests.Scenarios.Wizards.Fields.Adds.Authors;
using Tests.Scenarios.Wizards.Fields.Adds.Books;
using Tests.Scenarios.Wizards.Fields.Adds.Users;
using Tests.Scenarios.Components.Deletes;
using Tests.UnitTests.MySQL;

namespace Tests
{
    class Program
    {

        public static bool isAllComplate = true;
        public static int i = 0;
        
        static void Main(string[] args)
        {
            Execute(UnitTests());
            Execute(IntegrationTests());

            if (isAllComplate)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Tüm testler çalıştırıldı.");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("OK (" + i + " tests," + Config.data["assert_count"] + " asserts)");
                Config.data["assert_count"] = 0;
            }

            Console.ReadLine();

        }

        static void Execute(List<ITest> tests)
        {
            string nsTest = "";
            Config.data["assert_count"] = 0;
            foreach (ITest test in tests)
            {
                try
                {
                    test.Execute();
                    nsTest = test.GetName();
                    Console.Write(".");
                    i++;
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("");
                    }
                }
                catch (Exception exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("FAILURES!");
                    Console.WriteLine(i + " test(s)");
                    Console.WriteLine("");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("[" + test.GetName() + "]" + exception.Message + "!");
                    Config.data["assert_count"] = 0;
                    isAllComplate = false;
                    break;
                }

            }

        }

        static List<ITest> UnitTests()
        {
            return new List<ITest>()
            {
                new TableBuilder()
            };
        }

        static List<ITest> IntegrationTests()
        {
            return new List<ITest>()
            {

                new Login(),
                #region Simple Form Create and Save - Başlangıç Seviyesi Form Oluşturma ve Kayıt
		        new ReferencesPost(),
                new TablesPost(),
                new TablesToggleRelatedTable(),
                new ListTypesCreate(),
                new ListTypeValuesCreate(),
                new ComponentsCreate(),
                new TableComponentCreate(),
                new TableComponentAddIndex(),
                new WizardsPost(),
                new WizardsFieldsAdd(),
                new WizardsFieldsValidationsSave(),
                new FormsCreate(),
                new FormDesignToggleButton(),
                new FormDesignAddWizards(),
                new FormDesignPreview(),
                new FormsSave(),
                new FormDesignRemoveWizards(),
                new ComponentsDelete(),
                new ListTypesDelete(),
                new ReferencesDelete(),
                new TablesDelete(),
                new WizardsDelete(),
                new FormsDelete(),
                #endregion

                #region Lang Values Tests - Dil Karşılıkları Testleri

                // Alan tipleri dil karşılıkları test bloğu
                new ReferencesPost(),
                new ListTypesCreate(),
                new ComponentsCreate(),
                new LangValuesComponentsComponent(),
                new LangValuesComponentsUpdate(),
                new ComponentsDelete(),
                new ListTypesDelete(),
                new ReferencesDelete(),

                // Listeler dil karşılıkları test bloğu
                new ListTypesCreate(),
                new LangValuesListsByLang(),
                new LangValuesListsUpdate(),
                new ListTypesDelete(),

                // Liste verileri dil karşılıkları test bloğu
                new ListTypesCreate(),
                new ListTypeValuesCreate(),
                new LangValuesListValuesGetValues(),
                new LangValuesListValuesUpdate(),

                new ListTypesDelete(),

                // Wizardlar dil karşılıkları test bloğu 
                new TablesPost(),
                new WizardsPost(),
                new LangValuesWizardsWizards(),
                new LangValuesWizardsUpdate(),
                new WizardsDelete(),
                new TablesDelete(),

                // Sistem değerleri dil karşılıkları test bloğu 


                // Harici servisler dil karşılıkları test bloğu 
                new ServiceDefinitionsGetServices(),
                new ServiceDefinitionsUpdate(),

                // Harici servis parametreleri dil karşılıkları test bloğu 
                new ServiceParametersInit(),
                new ServiceParametersUpdate(),
                #endregion

                // Stil isimleri test bloğu
                new ComponentsStylesSave(),
                new ComponentsStylesDelete(),

                // Yönetici Senaryasou
                // ilk önce bir yönetici kaydı yapılır.
                new ManagersCreate(),
                new ManagersDelete(),
                new TablesGetRelated(),

                #region Kütüphane otomasyon testi

                new ReferencesPost(),

                new ComponentAuthorIdCreate(),
                new ComponentNameCreate(),
                new ComponentSurnameCreate(),
                new ComponentBookIdCreate(),
                new ComponentEditionCreate(),
                new ComponentPublisherNameCreate(),
                new ComponentUserIdCreate(),

                new TablePostUser(),
                new TablePostBooks(),
                new TablePostRent(),
                new TablePostAuthors(),

                new TableComponentAuthorsNameCreate(),
                new TableComponentAuthorsSurnameCreate(),
                new TableComponentByTable(),

                new TableComponentBooksNameCreate(),
                new TableComponentBooksPublisherNameCreate(),
                new TableComponentBooksEditionCreate(),
                new TableComponentBooksAuthorIdCreate(),

                new TableComponentRentsBookIdCreate(),
                new TableComponentRentsUserIdCreate(),

                new TableComponentUsersNameCreate(),
                new TableComponentUsersSurnameCreate(),

                new WizardPostAuthor(),
                new WizardFieldAuthorNameAdd(),
                new WizardFieldAuthorSurnameAdd(),

                new WizardPostBook(),
                new WizardFieldBookAuthorIdAdd(),
                new WizardFieldBookEditionAdd(),
                new WizardFieldBookNameAdd(),
                new WizardFieldBookPublisherNameAdd(),

                new WizardPostUser(),
                new WizardFieldUserNameAdd(),
                new WizardFieldUserSurnameAdd(),

                new FormAuthorRegistrationCreate(),
                new FormDesignAddAuthorWizard(),

                new FormBookRegistrationCreate(),
                new FormDesignAddBookWizard(),

                new FormUserRegistrationCreate(),
                new FormDesignAddUserWizard(),

                // Author Registration Formu wizard alanları dolrularak kaydedilecek.
                // Book Registration Formu wizard alanları dolrularak kaydedilecek.
                // User Registration Formu wizard alanları dolrularak kaydedilecek.

                new FormDesignRemoveAuthorWizard(),
                new FormDesignRemoveBookWizard(),
                new FormDesignRemoveUserWizard(),

                new WizardDeleteAuthors(),
                new WizardDeleteBooks(),
                new WizardDeleteUsers(),

                new FormsDeleteAuthorRegistration(),
                new FormsDeleteBookRegistration(),
                new FormsDeleteUserRegistration(),

                new TableDeleteAuthors(),
                new TableDeleteBooks(),
                new TableDeleteRent(),
                new TableDeleteUser(),

                new ComponentDeleteAuthorId(),
                new ComponentDeleteBookId(),
                new ComponentDeleteEdition(),
                new ComponentDeleteName(),
                new ComponentDeletePublisherName(),
                new ComponentDeleteSurname(),
                new ComponentDeleteUserId()
                #endregion

            };
            
        }
    }
}
