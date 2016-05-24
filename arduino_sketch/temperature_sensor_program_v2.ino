
const int sensorPin = A0;
const float baselineTemp = 20.0;
int AppState = 1;
int switchState = 0;
int grnLEDLmt = 22;
int ylwLEDLmt = 24;
int redLEDLmt = 26;

void setup()
{
  Serial.begin(9600);
  for (int pinNumber = 3; pinNumber < 6; pinNumber++)
  {
    pinMode(pinNumber, OUTPUT);
    digitalWrite(pinNumber, LOW);
  }
  pinMode(2, INPUT);
}

void loop()
{
  switchState = digitalRead(2);
  
  if (switchState == HIGH)
  {
    if (AppState == 1)
    {
      AppState = 2;
    }
    else if (AppState == 2)
    {
      AppState = 1;
    }
  }
  
  if (Serial.available() > 0)
  {
    String incomingCommand;
    while (Serial.available() > 0)
    {
      char incomingData = Serial.read();
      incomingCommand = incomingCommand + incomingData;
    }
    if (incomingCommand.equals("two"))
    {
      AppState = 2;
    }
    else if (incomingCommand.equals("one"))
    {
      AppState = 1;
    }
    else if (incomingCommand.startsWith("Grn"))
    {
      incomingCommand.remove(0, 3);
      grnLEDLmt = incomingCommand.toInt();
    }
    else if (incomingCommand.startsWith("Ylw"))
    {
      incomingCommand.remove(0, 3);
      ylwLEDLmt = incomingCommand.toInt();
    }
    else if (incomingCommand.startsWith("Red"))
    {
      incomingCommand.remove(0, 3);
      redLEDLmt = incomingCommand.toInt();
    }
  }
  
  if (AppState == 1)
  {
    int sensorVal = analogRead(sensorPin);
    float voltage = (sensorVal/1024.0) * 5.0;
    float temperature = (voltage - .5) * 100;
    Serial.print(temperature);
    
    /** old behaviour, changed to allow changing from GUI input
    if (temperature < baselineTemp)
    {
      digitalWrite(3, LOW);
      digitalWrite(4, LOW);
      digitalWrite(5, LOW);
    }
    else if (temperature >= baselineTemp + 2 && temperature < baselineTemp + 4)
    {
      digitalWrite(3, HIGH);
      digitalWrite(4, LOW);
      digitalWrite(5, LOW);
    }
    else if (temperature >= baselineTemp + 4 && temperature < baselineTemp + 6)
    {
      digitalWrite(3, HIGH);
      digitalWrite(4, HIGH);
      digitalWrite(5, LOW);
    }
    else if (temperature >= baselineTemp + 6)
    {
      digitalWrite(3, HIGH);
      digitalWrite(4, HIGH);
      digitalWrite(5, HIGH);
    }
    **/
    
    // Green LED
    if (temperature < grnLEDLmt)
    {
      digitalWrite(3, LOW);
    }
    else if (temperature >= grnLEDLmt)
    {
      digitalWrite(3, HIGH);
    }
    // Yellow LED
    if (temperature < ylwLEDLmt)
    {
      digitalWrite(4, LOW);
    }
    else if (temperature >= grnLEDLmt)
    {
      digitalWrite(4, HIGH);
    }
    // Red LED
    if (temperature < redLEDLmt)
    {
      digitalWrite(5, LOW);
    }
    else if (temperature >= grnLEDLmt)
    {
      digitalWrite(5, HIGH);
    }
    
    delay(1000);
  }
  else if (AppState == 2)
  {
    Serial.print("CLOSE");
    digitalWrite(3, LOW);
    digitalWrite(4, HIGH);
    digitalWrite(5, LOW);
    delay(250);
    digitalWrite(4, LOW);
    digitalWrite(5, HIGH);
    delay(250);
  }
}
