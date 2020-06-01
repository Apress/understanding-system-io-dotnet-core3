using System;
#if DEBUG
using System.Diagnostics;
#endif

namespace RVJ.IO {

    /*

        OVERVIEW
     


    */
    public class DirectoryInformation :  RVJ.IO.StreamInformation {

        #region Fields
        #endregion

        #region Constructors
        public DirectoryInformation() : base() {

            this.Type = StreamType.Directory;

            return;
        }

        public DirectoryInformation( StreamType type ) : this() {

            switch ( type ) {
                case StreamType.Directory: {

                };
                break;
                case StreamType.File: {

                };
                break;
                default: break;
            }

            return;
        }
        #endregion


        #region Public Properties
        #endregion
    };
};
