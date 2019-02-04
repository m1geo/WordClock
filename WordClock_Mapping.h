// M1GEO Word Clock V2
// Friday 01 Feb 2019
// www.george-smart.co.uk/wordclock

// The order of items in the second list, must match the powers in the first list.

// ENUM WORD vs power of 2 index number
const uint32_t w_IT = 1;
const uint32_t w_IS = 2;
const uint32_t w_TWENTY = 4;
const uint32_t w_TEN_A = 8;
const uint32_t w_HALF = 16;
const uint32_t w_A = 32;
const uint32_t w_FIVE_A = 64;
const uint32_t w_MIDNIGHT = 128;
const uint32_t w_QUARTER = 256;
const uint32_t w_PAST = 512;
const uint32_t w_TO = 1024;
const uint32_t w_SIX = 2048;
const uint32_t w_TEN = 4096;
const uint32_t w_FIVE = 8192;
const uint32_t w_FOUR = 16384;
const uint32_t w_SEVEN = 32768;
const uint32_t w_ONE = 65536;
const uint32_t w_TWELVE = 131072;
const uint32_t w_THREE = 262144;
const uint32_t w_EIGHT = 524288;
const uint32_t w_TWO = 1048576;
const uint32_t w_NINE = 2097152;
const uint32_t w_ELEVEN = 4194304;
const uint32_t w_IN = 8388608;
const uint32_t w_THE = 16777216;
const uint32_t w_EVENING = 33554432;
const uint32_t w_MORNING = 67108864;
const uint32_t w_AFTERNOON = 134217728;
const uint32_t w_NOON = 268435456;
const uint32_t w_M1GEO = 536870912;

// {word_enum, line, start_pixel, number_pixels}
// top left is line=0,start_pixel=0
uint8_t word_pixel_data[][3] = {
  {0,  0,  2}, // w_IT
  {0,  3,  2}, // w_IS
  {0,  6,  6}, // w_TWENTY
  {0, 12,  3}, // w_TEN_A
  {1,  0,  4}, // w_HALF
  {1,  1,  1}, // w_A
  {1,  3,  4}, // w_FIVE_A
  {1,  7,  8}, // w_MIDNIGHT
  {2,  1,  7}, // w_QUARTER
  {2, 10,  4}, // w_PAST
  {2, 13,  2}, // w_TO
  {3,  0,  3}, // w_SIX
  {3,  3,  3}, // w_TEN
  {3,  7,  4}, // w_FIVE
  {3, 11,  4}, // w_FOUR
  {4,  1,  5}, // w_SEVEN
  {4,  6,  3}, // w_ONE
  {4,  9,  6}, // w_TWELVE
  {5,  0,  5}, // w_THREE
  {5,  4,  5}, // w_EIGHT
  {5,  8,  3}, // w_TWO
  {5, 11,  4}, // w_NINE
  {6,  0,  6}, // w_ELEVEN
  {6,  8,  2}, // w_IN
  {6, 12,  3}, // w_THE
  {7,  0,  7}, // w_EVENING
  {7,  7,  7}, // w_MORNING
  {8,  0,  9}, // w_AFTERNOON
  {8,  5,  4}, // w_NOON
  {8, 10,  5}  // w_M1GEO
};
