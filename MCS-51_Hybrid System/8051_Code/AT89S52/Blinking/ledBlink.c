#include <REGX52.H>
 
 sbit led0 = P0^7; // 5mm red led
 sbit led1 = P1^7; // sck/3mm-blue led
 sbit led2 = P2^7; // 5mm green led
 sbit led3 = P3^7; // 5mm blue led
 
 void delay(unsigned int);


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

void ledBlink(unsigned char ledNum, unsigned int mstime) {
    switch(ledNum) {
        case 0:
            led0 = 1; // Turn LED on
            delay(mstime);
            led0 = 0; // Turn LED off
            delay(mstime);
            break;
        case 1:
            led1 = 1;
            delay(mstime);
            led1 = 0;
            delay(mstime);
            break;
        case 2:
            led2 = 1;
            delay(mstime);
            led2 = 0;
            delay(mstime);
            break;
        case 3:
            led3 = 1;
            delay(mstime);
            led3 = 0;
            delay(mstime);
            break;
        default:
            // Invalid LED number, do nothing
            break;
    }
}

 

 void main()
 {
	 		//P1=0x01; //  Port1, pin-1 is high, others are low.
	 	  //P1=0x08; //  Port1, pin-3 is high, others are low.
		P0 = 0x00;
	  P1 = 0x00;
	  P2 = 0x00;
	  P3 = 0x00;
	  
		 while(1)
		 {
			 //ledBlink(0,7000); 
			 //ledBlink(1,500); 
			 //ledBlink(2,2000); 
			 //ledBlink(3,5000); 
			 
		 }
 }

