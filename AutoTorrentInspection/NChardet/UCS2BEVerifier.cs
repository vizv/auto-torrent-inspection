﻿namespace NChardet
{
    public sealed class UCS2BEVerifier : Verifier
    {
        static int[]  _cclass   ;
        static int[]  _states   ;
        static int    _stFactor ;
        static string _charset  ;

        public override int[]  cclass()   => _cclass;
        public override int[]  states()   => _states;
        public override int    stFactor() => _stFactor;
        public override string charset()  => _charset;

        public UCS2BEVerifier()
        {
            _cclass = new int[256/8] ;
            _cclass[0]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[1]  = ((  ((  (0 << 4) | 0  ) << 8) | (2 << 4) | 0 ) << 16) | ((  (0 << 4) | 1 ) << 8) | (0 << 4) | 0 ;
            _cclass[2]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[3]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (3 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[4]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[5]  = ((  ((  (0 << 4) | 0  ) << 8) | (3 << 4) | 3 ) << 16) | ((  (3 << 4) | 3 ) << 8) | (3 << 4) | 0 ;
            _cclass[6]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[7]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[8]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[9]  = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[10] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[11] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[12] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[13] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[14] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[15] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[16] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[17] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[18] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[19] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[20] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[21] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[22] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[23] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[24] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[25] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[26] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[27] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[28] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[29] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[30] = ((  ((  (0 << 4) | 0  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;
            _cclass[31] = ((  ((  (5 << 4) | 4  ) << 8) | (0 << 4) | 0 ) << 16) | ((  (0 << 4) | 0 ) << 8) | (0 << 4) | 0 ;

            _states = new int[7] ;
            _states[0] = ((  ((  (eError << 4) | eError  ) << 8) | (3      << 4) | 4      ) << 16) | ((  (eError << 4) |      7 ) << 8) | (7 <<      4) | 5 ;
            _states[1] = ((  ((  (eItsMe << 4) | eItsMe  ) << 8) | (eItsMe << 4) | eItsMe ) << 16) | ((  (eError << 4) | eError ) << 8) | (eError << 4) | eError ;
            _states[2] = ((  ((  (eError << 4) | eError  ) << 8) | (6      << 4) | 6      ) << 16) | ((  (6      << 4) |      6 ) << 8) | (eItsMe << 4) | eItsMe ;
            _states[3] = ((  ((  (6      << 4) | 6       ) << 8) | (eItsMe << 4) | 6      ) << 16) | ((  (6      << 4) |      6 ) << 8) | (6 <<      4) | 6 ;
            _states[4] = ((  ((  (eError << 4) | 7       ) << 8) | (7      << 4) | 5      ) << 16) | ((  (6      << 4) |      6 ) << 8) | (6 <<      4) | 6 ;
            _states[5] = ((  ((  (6      << 4) | 6       ) << 8) | (6      << 4) | eError ) << 16) | ((  (6      << 4) |      6 ) << 8) | (8 <<      4) | 5 ;
            _states[6] = ((  ((  (eStart << 4) | eStart  ) << 8) | (eError << 4) | eError ) << 16) | ((  (6      << 4) |      6 ) << 8) | (6 <<      4) | 6 ;

            _charset  =  "UTF-16BE";
            _stFactor =  6;
        }

        public override bool isUCS2() => true;
    }
}
