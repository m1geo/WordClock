// M1GEO Word Clock (V2 PCB)
// First revision: 04 Feb 2019
// Compiled Arduino 1.8.8
// https://www.george-smart.co.uk/wordclock
// https://github.com/m1geo/WordClock

// Set clock with:  2020,01,01,11,59,00,

#include <DS3232RTC.h>          // https://github.com/JChristensen/DS3232RTC
#include <Adafruit_GFX.h>
#include <Adafruit_NeoMatrix.h>
#include <Adafruit_NeoPixel.h>
#include <EEPROM.h>

#include "WordClock_Mapping.h"

#define PROTOCOL_VERSION 1

// IO Pins
#define DISP_PIN     6
#define LDR          A0

// EEPROM addressing
enum EEPROM_ADDRESSES {
  E_LONG_MONTH,
  E_SCROLL_DELAY,
  E_TEMP_UNITS,
  E_MANUAL_BRIGHTNESS,
  E_PERSONALISATION_BITS,
  E_HALF_INTERVALS,
};

// User Options
#define TEMP_UNITS_C 1
#define TEMP_UNITS_F 2
#define TEMP_UNITS_K 3
uint8_t LONG_MONTH = 1;
uint8_t SCROLL_DELAY = 25;
uint8_t TEMP_UNITS = TEMP_UNITS_C;
uint8_t MANUAL_BRIGHTNESS = 0;
uint8_t PERSONALISATION_BITS = 0b00011111;
uint8_t HALF_INTERVALS = 0;

// Display Config - DON'T TOUCH
#define DISP_LINES   9
#define DISP_WIDTH   15
#define MAX_BRIGHT   128
#define MIN_BRIGHT   16
#define LED_PER_CHAR 6


Adafruit_NeoMatrix matrix = Adafruit_NeoMatrix(DISP_WIDTH, DISP_LINES, DISP_PIN,
  NEO_MATRIX_TOP + NEO_MATRIX_LEFT +
  NEO_MATRIX_ROWS + NEO_MATRIX_PROGRESSIVE,
  NEO_GRB + NEO_KHZ800);

const uint16_t colours[] =
{
  matrix.Color(255, 255, 255),  // white
  matrix.Color(255, 0, 0),      // red
  matrix.Color(0, 255, 0),      // green
  matrix.Color(0, 0, 255),      // blue
  matrix.Color(255, 255, 0),    // yellow (red + green)
  matrix.Color(0, 255, 255),    // cyan (green + blue)
  matrix.Color(255, 0, 255)     // magenta (red + blue)
};

unsigned int ldra[5] = {0, 0, 0, 0, 0};
unsigned int LDRVAL = 0;
unsigned int BRIGHT = MAX_BRIGHT; // average scaling between 0-255 for LED brightness.
unsigned int BRIGHTOLD = BRIGHT;
const unsigned int num_colours = sizeof(colours)/sizeof(uint16_t);
int x = matrix.width();
int pass = 0;
uint32_t z = 0;
char disp_str[20];

void setup()
{
  matrix.begin();
  matrix.setTextWrap(false);
}

int col = 0;
  
void loop() {

  matrix.setBrightness(BRIGHT/8);
  col = (col + 1) % 7;
  for(int l = 0; l < DISP_LINES; l++)
  {
    for(int p = 0; p < DISP_WIDTH; p++)
    {
      matrix.drawPixel(p, l, colours[col]);
      delay(10);
      matrix.show();
    }
  }
  matrix.show();
  //delay(250);
}
