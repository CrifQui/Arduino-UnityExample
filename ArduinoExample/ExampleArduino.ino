int boton=4;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(boton, INPUT);
  digitalWrite(boton, HIGH);
}

void loop() {
  // put your main code here, to run repeatedly:
 if(digitalRead(boton)==LOW){
    Serial.println("1");
    
    delay(20);
  }

}
