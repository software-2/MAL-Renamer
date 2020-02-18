using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALRenamer
{
    public class ValidationState
    {
        private ValidationState(ErrorType type, string message) { Type = type; Message = message; }

        public string Message { get; }
        public ErrorType Type { get; }

        public enum ErrorType : ushort
        {
            NoIssues,
            Warning,
            Error
        }
        
        public static ValidationState Good
        {
            get
            {
                return new ValidationState(
                    ErrorType.NoIssues,
                    "No issues detected, you're good to go!"
                );
            }
        }

        public static ValidationState SpecifyFolder
        {
            get
            {
                return new ValidationState(
                    ErrorType.Error,
                    "You must specify a Source Folder first!"
                );
            }
        }

        public static ValidationState NoFilesPresent
        {
            get
            {
                return new ValidationState(
                    ErrorType.Error,
                    "Error! No files present in the folder specified!"
                );
            }
        }

        public static ValidationState NoEpisodes
        {
            get
            {
                return new ValidationState(
                    ErrorType.Error,
                    "Error! No episodes have been loaded! Click the 'Search' button to find your anime."
                );
            }
        }

        public static ValidationState TooManyFiles
        {
            get
            {
                return new ValidationState(
                    ErrorType.Error,
                    "Error! There are more files selected for editing than exist in this anime! This means you likely have some extra files (such as " +
                    "intros/outros, special episodes, etc.). Uncheck the checkbox from a row to omit it from editing. (You can double click a row to manually rename that file.)"
                );
            }
        }

        public static ValidationState TooManyEpisodes
        {
            get
            {
                return new ValidationState(
                    ErrorType.Warning,
                    "Warning! There are more episodes in this anime than you have selected for editing! Are you sure this is what you want to do? " +
                    "If you're editing a partial season, make sure you're starting at the right episode number."
                );
            }
        }

    }
}
