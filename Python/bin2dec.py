# imports
import math

# methods
def IsInt(strNumber):
    return type(strNumber) == int

def CorrectOrder(str):
    size = len(str)
    errorCount = 0
    
    for i in range(0, size, 1):
        if(str[i] not in ('1', '0')):
            errorCount += 1
    return errorCount == 0

# main program
while True:
  try:    
      binaryNumber = input('Enter the binary number >>')
      reverseNumber = binaryNumber[::-1]
      size = len(binaryNumber)
      dec = 0.0
       
      if not CorrectOrder(binaryNumber):
          print('Not a binary number, try again')
          continue
       
      if size > 8:
          print('It must contain less than 8 digits, try again')
          continue
       
      for i in range(0, size, 1):
        dec += math.pow(2, i) * int(reverseNumber[i])
        
      print('Binary: {} | Decimal: {}' .format(binaryNumber, int(dec)))
      break
  except ValueError:
      print('Only numbers allowed, try again')
      continue
  except Exception:
      print('Error: ' + Exception)
      break
    