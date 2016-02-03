﻿namespace NChardet
{
    public sealed class GB18030Verifier : Verifier
    {
        static int[]  _cclass   ;
        static int[]  _states   ;
        static int    _stFactor ;
        static string _charset  ;

        public override int[]  cclass()   => _cclass;
        public override int[]  states()   => _states;
        public override int    stFactor() => _stFactor;
        public override string charset()  => _charset;

        public GB18030Verifier()
        {
            _cclass = new int[256/8] ;
            _cclass[0]  = ((  ((  (1 << 4) | 1  ) << 8) | (1 << 4) | 1 ) << 16) | ((  (1 << 4) | 1 ) << 8) | (1 << 4) | 1 ;
            _cclass[1]  = ((  ((  (0 << 4) | 0  ) << 8) | (1 << 4) | 1 ) << 16) | ((  (1 << 4) | 1 ) << 8) | (1 << 4) | 1 ;
            _cclass[2]  = ((  ((  (1 << 4) | 1  ) << 8) | (1 << 4) | 1 ) << 16) | ((  (1 << 4) | 1 ) << 8) | (1 << 4) | 1 ;
            _cclass[3]  = ((  ((  (1 << 4) | 1  ) << 8) | (1 << 4) | 1 ) << 16) | ((  (0 << 4) | 1 ) << 8) | (1 << 4) | 1 ;
            _cclass[4]  = ((  ((  (1 << 4) | 1  ) << 8) | (1 << 4) | 1 ) << 16) | ((  (1 << 4) | 1 ) << 8) | (1 << 4) | 1 ;
            _cclass[5]  = ((  ((  (1 << 4) | 1  ) << 8) | (1 << 4) | 1 ) << 16) | ((  (1 << 4) | 1 ) << 8) | (1 << 4) | 1 ;
            _cclass[6]  = ((  ((  (3 << 4) | 3  ) << 8) | (3 << 4) | 3 ) << 16) | ((  (3 << 4) | 3 ) << 8) | (3 << 4) | 3 ;
            _cclass[7]  = ((  ((  (1 << 4) | 1  ) << 8) | (1 << 4) | 1 ) << 16) | ((  (1 << 4) | 1 ) << 8) | (3 << 4) | 3 ;
            _cclass[8]  = ((  ((  (2 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[9]  = ((  ((  (2 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[10] = ((  ((  (2 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[11] = ((  ((  (2 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[12] = ((  ((  (2 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[13] = ((  ((  (2 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[14] = ((  ((  (2 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[15] = ((  ((  (4 << 4) | 2  ) << 8) | (2 << 4) | 2 ) << 16) | ((  (2 << 4) | 2 ) << 8) | (2 << 4) | 2 ;
            _cclass[16] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 5 ;
            _cclass[17] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[18] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[19] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[20] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[21] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[22] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[23] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[24] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[25] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[26] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[27] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[28] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[29] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[30] = ((  ((  (6 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;
            _cclass[31] = ((  ((  (0 << 4) | 6  ) << 8) | (6 << 4) | 6 ) << 16) | ((  (6 << 4) | 6 ) << 8) | (6 << 4) | 6 ;

            _states = new int[6];
            _states[0] = ((  ((  (eError << 4) |      3  ) << 8) | (eStart << 4) | eStart ) << 16) | ((  (eStart << 4) | eStart ) << 8) | (eStart << 4) | eError ;
            _states[1] = ((  ((  (eItsMe << 4) | eItsMe  ) << 8) | (eError << 4) | eError ) << 16) | ((  (eError << 4) | eError ) << 8) | (eError << 4) | eError ;
            _states[2] = ((  ((  (eStart << 4) | eError  ) << 8) | (eError << 4) | eItsMe ) << 16) | ((  (eItsMe << 4) | eItsMe ) << 8) | (eItsMe << 4) | eItsMe ;
            _states[3] = ((  ((  (eError << 4) | eError  ) << 8) | (eError << 4) | eError ) << 16) | ((  (eStart << 4) | eStart ) << 8) | (eError << 4) | 4 ;
            _states[4] = ((  ((  (eError << 4) | eItsMe  ) << 8) | (eError << 4) | eError ) << 16) | ((  (eError << 4) |      5 ) << 8) | (eError << 4) | eError ;
            _states[5] = ((  ((  (eStart << 4) | eStart  ) << 8) | (eStart << 4) | eStart ) << 16) | ((  (eStart << 4) | eStart ) << 8) | (eError << 4) | eError ;

            _charset =  "GB18030";
            _stFactor =  7;
        }
        public override bool isUCS2() => false;
    }
}
