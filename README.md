# Research-Redis
## Download 
 > [See here](https://github.com/microsoftarchive/redis/releases)
## Basic Command

 1. set สร้าง key แบบธรรมดา
 	 ``` 
	 example : set [key] [Value] 
	           set name Kittisak
	 Result : OK
	 ```
 2. setnx สร้าง key แบบเช็คค่าซ้ำ ถ้ามีค่าซ้ำจะไม่ update ทับ แต่ถ้าไม่มี key นี้จะสร้างให้ใหม่
   ```
	 example : setnx [key] [Value]
	           setnx name Kittisak
	 Result : (integer) 0
   ```
	 
	 
 3. setex สร้าง key แบบกำหนดเวลา expire
	 ```
	 example : setex [Key] [Timeout(Second)] [Value]
						setex name 10 Kittisak
	 Result : OK
	 ```
	
	 
 4. mset สร้าง key ได้หลายๆ key พร้อมกันแต่ถ้า  key ซ้ำจะเอาค่าล่าสุดเสมอ
	 ```
	 example : mset no1 10 no2 20 no2 30 [Key Value...]
	 Result: no1 = 10
		     no2 = 30
	 ```
5. strlen เช็คLength value ของ key
   ```
	 example : strlen [key]
	           strlen name
	 Result : (integer) 8    => 8 เพราะ Kittisak มี 8 ตัวอักษร
	 ```
6. ttl ใช้สำหรับดูเวลาที่เหลืออยู่สำหรับคีย์นั้นๆ (Timeout to live)
   ```
	 example : ttl [Key]
	           ttl name
	 Result : (integer) 7 
	 ```
7. get เรียก key ออกมาแสดงทีละ 1 key
	 ```
	 example : get [Key]
	           get name
	 Result : "Kittisak"
	 ```
8. keys แสดงคีย์ทั้งหมดออกมาแสดง หรือ ใส่เงื่อนไขก็ได้
	 ```
	 example : keys [Pattern]
	           keys *
	 Result : name1
	          name2
	 ```
9. append ต่อท้ายข้อความ
	 ```
	 example : append [key]
	           append name " TaengOn"
	 Result : "Kittisak TaengOn"
	 ```
10. incr เพิ่มค่าทีละ 1
	 ```
	 example : set num1 20
	           incr [Key]
               incr num1
	 Result : num1 = 21
	 ```
11. decr ลดค่าทีละ 1 
	 ```
	 example : set num2 10
	           decr [Key]
             decr num2
	 Result : num2 = 9
	 ```
12. incrby เพิ่มค่า แบบกำหนดค่าเองได้
	 ```
	 example : incrby [Key] [Value]
	           incrby num1 5
	 Result : num1 = 26 (26 เพราะด้านบน num1 มีการบวกค่าไป 1 แล้ว)
	 ```
13. decrby ลดค่า แบบกำหนดค่าเองได้
	 ```
	 example : decrby [Key] [Value]
	           decrby num2 4
	 Result : num2 = 5 (5 เพราะด้านบน num2 มีการลดค่าไป 1 แล้ว)
	 ```

 
