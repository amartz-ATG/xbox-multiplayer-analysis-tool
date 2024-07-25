// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Windows.Input;

namespace XMAT
{
    public static class QueryCommands
    {
        public static readonly RoutedUICommand LoadQuery =
            new(Localization.GetLocalizedString("QUERY_CMD_LOAD"), "Load Query", typeof(QueryCommands));

        public static readonly RoutedUICommand SaveQuery =
            new(Localization.GetLocalizedString("QUERY_CMD_SAVE"), "Save Query", typeof(QueryCommands));

        public static readonly RoutedUICommand ValidateQuery =
            new(Localization.GetLocalizedString("QUERY_CMD_VALIDATE"), "Validate Query", typeof(QueryCommands));

        public static readonly RoutedUICommand RevertQuery =
            new(Localization.GetLocalizedString("QUERY_CMD_REVERT"), "Revert Query", typeof(QueryCommands));

        public static readonly RoutedUICommand QueryErrorSelected =
            new(Localization.GetLocalizedString("QUERY_CMD_ERROR_SELECT"), "Query Error Selected", typeof(QueryCommands));
    }
}
