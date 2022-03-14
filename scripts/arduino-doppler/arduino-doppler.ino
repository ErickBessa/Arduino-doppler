#include <EEPROM.h>

const int addr = 0;
const int pinRele = 2;
const int pinButton = 12;

byte velMax;
long velocidade;
String receiveData;
String receiveOld;
bool bCmdDoppler;

void setup() {
  Serial.begin(9600);
  while (!Serial);

  pinMode(pinRele, OUTPUT);

  pinMode(pinButton, INPUT);  

  pinMode(13, OUTPUT);
  digitalWrite(13, LOW);

  velMax = EEPROM.read(addr);
  delay(100);
  Serial.println("VELMAX#" + String(velMax));

  bCmdDoppler = false;
}

void loop() {

  if (digitalRead(pinButton) == HIGH)
  {
    digitalWrite(pinRele, HIGH);
    delay(1000);
    digitalWrite(pinRele, LOW);
    return;
  }

  if (Serial.available() > 0)
  {
    receiveData = Serial.readString();

    //Checa se é um comando para o Doppler.
    if (receiveData.indexOf('*') > 0)
    {
      //Buypass do comando Doppler.
      String sensibilidade = receiveData.substring(receiveData.indexOf('*') + 1);
      Serial.print(sensibilidade + "\n");
      bCmdDoppler = true;
      return;
    }

    //Checa se é um comando de velocidade.
    if (receiveData.indexOf('#') > 0)
    {
      String vel = receiveData.substring(receiveData.indexOf('#') + 1);
      long iVel = vel.toInt();
      if (iVel != 0)
      {
        EEPROM.update(addr, iVel);
        delay(100);
        velMax = EEPROM.read(addr);
        delay(100);
        Serial.println("ACK#" + vel + "#Km/h");
      }
      else
      {
        Serial.println("NACK#" + vel + "#Km/h");
      }
    }
    else
    {
      //Se não for um comando.
      if (receiveData != receiveOld)
      {
        receiveOld = receiveData;

        //Get velocity.
        long lVelMax = velMax;
        velocidade = receiveData.toInt();

        if (bCmdDoppler)
        {
          if (velocidade == 0)
            Serial.println("DPP*SEN*" + String(receiveData));
          else
            Serial.println("DPP*SEN*" + String(velocidade));

          bCmdDoppler = false;
          return;
        }

        //Checa se a velocidade é válida.
        if ((velocidade == 0) )
        {
          Serial.println(receiveData);
          return;
        }

        //Checa se é um afastamento
        if (velocidade < 0)
        {
          velocidade = (velocidade * -1);
        }

        if (velocidade > lVelMax )
        {
          Serial.print("VEL#ACIMA#" + String(velocidade) + "#Km/h");
          digitalWrite(pinRele, HIGH);
          delay(1000);
          digitalWrite(pinRele, LOW);
        }
        else
        {
          Serial.print("VEL#ABAIXO#" + String(velocidade) + "#Km/h");
        }
      }
    }
  }

  delay(50);
  digitalWrite(13, HIGH);
  delay(50);
  digitalWrite(13, LOW);
}
