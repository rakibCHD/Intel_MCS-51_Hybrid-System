#include <REGX52.H>

/*
	//Port-->0,1,2,3
	// Only PORT-0 is PulledUp for Activate.
	//PORT=[8,4,2,1;8,4,2,1]
 //Index=[7,6,5,4,3,2,1,0]

 sbit led0 = P0^7; // Red
 sbit led1 = P1^7; //Yellow;sck
 sbit led2 = P2^7; //Green
 sbit led3 = P3^7; //Blue
 */
 
 
 // Delay Function
 void delay(unsigned int ms)
{
    unsigned int i;
    for(i=0; i<ms; i++)
    {
        TMOD &= 0xF0;  // Clear Timer0 control bits
        TMOD |= 0x01;  // Set Timer0 in Mode1 (16-bit)

        TH0 = 0xFC;    // Load high byte for 1ms delay
        TL0 = 0x66;    // Load low byte  for 1ms delay

        TF0 = 0;       // Clear Timer0 overflow flag
        TR0 = 1;       // Start Timer0

        while(TF0 == 0); // Wait until Timer0 overflows

        TR0 = 0;       // Stop Timer0
        TF0 = 0;       // Clear overflow flag again
    }
 }

 
 void red(unsigned int ms)
 {
				P0 = 0x80;  //Port0; Pin7 = High; Others = Low;
				delay(ms);
				P0 = 0x00;  //Port0; All-Pin = Low;
				delay(ms);
 }
 
  void yellow(unsigned int ms)
 {
				P1 = 0x80;  //Port1; Pin7 = High; Others = Low;
				delay(ms);
				P1 = 0x00;  //Port1; All-Pin = Low;
				delay(ms);
 }
 
  void green(unsigned int ms)
 {
				P2 = 0x80;  //Port2; Pin7 = High; Others = Low;
				delay(ms);
				P2 = 0x00;  //Port2; All-Pin = Low;
				delay(ms);
 }
 
   void blue(unsigned int ms)
 {
				P3 = 0x80;  //Port3; Pin7 = High; Others = Low;
				delay(ms);
				P3 = 0x00;  //Port3; All-Pin = Low;
				delay(ms);
 }

 
 
  void main()
 {
	 // Initially all ports pin is LOW.
	 //--------------------
	 P0 = 0x00;
	 P1 = 0x00;
	 P2 = 0x00;
	 P3 = 0x00;
	 //--------------------

		while(1)
			{
					red(5000);
					blue(1000);
			}
 }
