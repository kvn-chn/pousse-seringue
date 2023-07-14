/*
 * Project name:
     HID_Read_Write_Interrupt (Testing the USB HID connection)
 * Copyright:
     (c) Mikroelektronika, 2011.
 * Revision History:
     20110929:
       - initial release (FJ);
 * Description:
     This example establishes connection with the HID terminal that is active
     on the PC. Upon connection establishment, the HID Device Name will appear
     in the respective window. After that software will wait for data and
     it will return received data back.
 * Test configuration:
     MCU:             PIC18F2550
                      http://ww1.microchip.com/downloads/en/DeviceDoc/39632D.pdf
     Dev.Board:       EasyPIC7 - ac:USB
                      http://www.mikroe.com/easypic/
     Oscillator:      HS, 8.000 MHz  (USB osc. is raised with PLL to 48.000MHz)
     Ext. Modules:    None.
     SW:              mikroC PRO for PIC
                      http://www.mikroe.com/mikroc/pic/
 * NOTES:
     (*) Be VERY careful about the configuration flags for the 18F4550 - there's
     so much place for mistake!
    - Place jumpers J12 in the right (USB) position.
 */
#define Inp1 PORTA.RA4
#define Inp2 PORTA.RA5
#define Inp3 PORTC.RC0
#define Inp4 PORTC.RC6
#define Inp5 PORTC.RC7
unsigned char PORT[4]={0b11110101,0b11111001,0b11111010,0b11110110};
unsigned char pas=0;
unsigned long i=0;
unsigned char readbuff[64] absolute 0x500;   // Buffers should be in USB RAM, please consult datasheet
unsigned char writebuff[64] absolute 0x540;
long temps=0,seuil_temps=520,valH=0,valM=0,ValL=0;   // seuil_temps=temps entre pas=520*20µs
long nbPasRestant = 0;
long nbPas1 = 0, nbPas2 = 0, nbPas3 = 0, nbPas4 = 0, nbPasInit = 0;
long nbVol1 = 0, nbVol2 = 0, nbVol3 = 0, nbVol4 = 0, nbVolTot = 0;
long count = 0;
char cnt;
char kk;
unsigned short start = 0;
int sens = 0;
int val = 0;

void interrupt(){
if (TMR0IF_bit)   // parametrer une interruption toutes les 20µs a partir de Timer0
   {
   LATB.RB4 = 1;
    TMR0IF_bit=0;
    //LATB.RB0=1;  // pour verification de periode de 20µs
    TMR0L=147;
    temps++;
    if (temps>=seuil_temps)
       {
       // drapeau deplacement d'un pas moteur utilise une sortie pour faire des tests
       LATB.RB5 = 1;
          temps=0;
       }
    LATB.RB4 = 0;
    //LATB.RB0=0;
   }
else USB_Interrupt_Proc();  // USB servicing is done inside the interrupt

}
void main(void){
  long valeur=0;
  ADCON1 |= 0x0F;                         // Configure all ports with analog function as digital
  CMCON  |= 7;                            // Disable comparators
  T2CON=0b101;
  PR2 = 200;
  //CCP2CON=0b1100;
  //CCP1CON=0b1100;
  HID_Enable(&readbuff,&writebuff);       // Enable HID communication
   TRISB=0;
   TRISA=0b111111;
   TRISC=0b11000001;
   INTCON= 0xA0;
   TMR0L=150;
   T0CON=0b11001000;
   LATB.RB7 = 1;
  while(1){
    if (HID_Read()) {
      switch (readbuff[0]){
             case 0x80:
             //      PORTB=readbuff[1];
                  break;
             case 1:
                  PORTB= readbuff[1];
                  break;
             case 2:
                  valH =  readbuff[3];
                  valH=(valH<<16);
                  valH&=0xFF0000;
                  valM= readbuff[2];
                  valM=(valM<<8);
                  valM&=0xFF00;
                  valL=readbuff[1] & 0xFF;
                  seuil_temps=valH+valM+valL;
                  temps=0;
                  break;
             case 3:
                  LATB.RB7 = readbuff[1]& 1;
                  readbuff[0] = 0;
                  break;
             case 4:  // Recevoir nbPas IHM
                  nbPas1 = readbuff[1] & 0xFF;
                  nbPas2 = readbuff[2];
                  nbPas2 = (nbPas2 << 8);
                  nbPas2&=0xFF00;
                  nbPas3 = readbuff[3];
                  nbPas3 = (nbPas3 << 16);
                  nbPas3&=0xFF0000;
                  nbPas4 = readbuff[4];
                  nbPas4 = (nbPas4 << 24);
                  nbPas4&= 0xFF000000;
                  nbPasInit = nbPas4+nbPas3+nbPas2+nbPas1;
                  
                  if (readbuff[5] == 1)  // reset valeur à 0 au démarrage IHM
                  {
                    nbPasRestant = 0;
                    count = 0;
                    writebuff[14]= nbPasRestant & 0xFF;
                    writebuff[15]= (nbPasRestant & 0xFF00)>>8;
                    writebuff[16]= (nbPasRestant & 0xFF0000)>>16;
                    writebuff[17] = (nbPasRestant & 0xFF000000)>>24;
                    
                    writebuff[18]= count & 0xFF;
                    writebuff[19]= (count & 0xFF00)>>8;
                    writebuff[20]= (count & 0xFF0000)>>16;
                    writebuff[21] = (count & 0xFF000000)>>24;
                  } else {
                    nbPasRestant = nbPasInit;
                  }
                  break;
             }
             readbuff[0] = 0;
    }
     if ( LATB.RB5) // temps > seuil_temps
   {
    if (LATB.RB7) // moteur en marche
       {
            count++;
            nbPasRestant = nbPasInit - count;
            
            writebuff[14]= nbPasRestant & 0xFF;
            writebuff[15]= (nbPasRestant & 0xFF00)>>8;
            writebuff[16]= (nbPasRestant & 0xFF0000)>>16;
            writebuff[17] = (nbPasRestant & 0xFF000000)>>24;
            
            writebuff[18]= count & 0xFF;
            writebuff[19]= (count & 0xFF00)>>8;
            writebuff[20]= (count & 0xFF0000)>>16;
            writebuff[21] = (count & 0xFF000000)>>24;
            
            if (nbPasRestant <= 0)
            {
               LATB.RB7=0; // arret moteur
            }
         pas =i%4;
         PORTB=(PORTB|0xF) & PORT[pas];
         if (LATB.RB6 == 1) sens = 1;
         if (LATB.RB6 == 0) sens = -1;
         i+= sens;
       }
    LATB.RB5=0; // temps < seuil_temps
   }

   writebuff[1]=PORTB;
   writebuff[2]=Inp1 + 2*Inp2 +4*Inp3 + 8*Inp4 + 16*Inp5;
   // writebuff[2]=PORTA.RA4 + 2*PORTA.RA5;
   writebuff[7]=valL;
   writebuff[8]=(valM>>8);
   writebuff[9]=(valH>>16);
   
   writebuff[10]= nbPas1;
   writebuff[11]= (nbPas2 >>8);
   writebuff[12]= (nbPas3 >>16);
   writebuff[13] = (nbPas4 >>24);
   
   HID_Write(&writebuff,64);
  }

}