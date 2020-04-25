Public Class Form1
    'GLOBAL VARIABLES
    'Used to input choice on user options
    Dim choice As Integer = 0
    Public Property success As Boolean
    Dim pick As Boolean = False
    Dim needle As Boolean = False
    Dim noise As Integer = 0
    Dim prisoners As Integer
    Dim book As Boolean = False
    Private Sub NoKey()
        choice = InputBox("You look around the room. " & vbCrLf & vbCrLf & "1. Check underneath bed " & vbCrLf & "2. Investigate in your drawers." & vbCrLf & "3. Unlock the gate.")
        If (choice = 1) Then
            MsgBox(“You search under the bed but all you find are huge dust balls.”)
            NoKey()
        End If
        If (choice = 2) Then
            MsgBox(“You search in the drawers and find only a single paper clip.”)
            pick = True
            NoKey()
        End If
        If (choice = 3) Then
            If (pick = False) Then
                MsgBox("You try and unlock the gate however it seems to require a key. Maybe there is a way to pick the lock.")
                NoKey()
            ElseIf (pick = True) Then
                MsgBox("You begin to try and pick the lock.")
                Maze_Room1.ShowDialog()
                While (success = False)
                    Maze_Room1.ShowDialog()
                End While
                If (success = True) Then
                    KeyPad()
                End If
            End If
        End If

        'Need to do other options here (#2 and #1 if statements)
    End Sub


    Private Sub Keys()
        'Runs when user successfully goes through the right sequence, (May need editing. Long and poorly written by yours truly)
        MsgBox("You reach through the bars and carefully snatch the key off the guard's waist as he turns around to glance at the bird. 'Oh, that bird is for another test. No need to worry about it. Well I am going to check in on the others. Prepare for testing tomorrow.' The guard leaves the area.")
        choice = InputBox("1. Unlock the gate.")
        KeyPad()
    End Sub

    Public Sub KeyPad()
        choice = InputBox(“You step into a bright hallway. There is one door  to your left and one door to your right. Which way would you like to head?” & vbCrLf & “1. Right” & vbCrLf & “2. Left”)
        If (choice = 1) Then
            MsgBox(“You find a floorplan of the building, with four mathematical equations on the back of it. The equations are:” & vbCrLf & “(2-3)^2 * (2+8)^2 - (92.8 + .2 + .6 + .4)” & vbCrLf & “2x - 8 = 5x - 20” & vbCrLf & “(82/2 + 1) - 84/2” & vbCrLf & “2 + 6 * 2 / 6”)
            KeyPad()
        ElseIf (choice = 2) Then
            choice = InputBox(“At the end of this room, there is secure, locked door with a 4 digit passcode lock.” & vbCrLf & vbCrLf & “1. Attempt the code” & vbCrLf & “2. Go back to the hallway.”)
            If (choice = 1) Then
                Form3.ShowDialog()
            ElseIf (choice = 2) Then
                KeyPad()
            End If

        End If
    End Sub
    Public Sub PastLock()
        Dim pagenum As Integer
        choice = InputBox("1. Search shelves" & vbCrLf & "2. Open Puzzle Box on Table" & vbCrLf & "3. Look at electronic device" & vbCrLf & "4. Head Towards the Laboratory")
        If (choice = 1) Then
            If (needle = False) Then
                MsgBox("You find an odd book. Something rattles inside as you take it off the shelf. You try opening the book but the cover page won't budge. However, you notice a strange hole at the bottom of the book.")
                PastLock()
            ElseIf (needle = True) Then
                MsgBox("You insert the needle into the hole and the cover of the book pops up! Inside you find a few items: a hackey sack and a lighter.")
                book = True
                PastLock()
            End If
        ElseIf (choice = 2) Then
            Form5.ShowDialog()
        ElseIf (choice = 3) Then
            pagenum = InputBox("You walk up to device. It's just a quote finder of some book. It asks you to enter the chapter, page, and line (all numbers, no spaces)")
            If (pagenum <> 71532) Then
                MsgBox("The line just reads nonsense.")
                PastLock()
            ElseIf (pagenum = 71532) Then
                MsgBox("The line reads 'PASSWORD: TO BE DECIDED'")
                PastLock()
            End If
        ElseIf (choice = 4) Then
            If (prisoners = 0) Then
                Prisoner()
            ElseIf (prisoners = 1) Then
                Lab()
            End If
        End If
    End Sub
    Public Sub Prisoner()
        MsgBox("You slowly walk into the labrotory. As you glance around the room, you see 3 other prisoners, tied down on tables, being tested on. Finally, you see a guard, sitting in the corner of the room, asleep. You stealthily creep towards him, until you can hear his breath just feet away. Suddenly you lunge on him, wrapping your hands around his throat. As soon as his body goes limp, you start removing his clothes and putting them on yourself. You decide they will be an ample disguise.")
        choice = InputBox("After putting on the guards clothes, you turn around and see the other prisoners. Would you like to:" & vbCrLf & "1. Help the prisoners to safety with you" & vbCrLf & "2. Leave the prisoners for dead")
        If (choice = 1) Then
            noise = noise + 1
            MsgBox("You decide to help the prisoners and they join you.")
        ElseIf (choice = 2) Then
            MsgBox("You leave the prisoners behind, but the guilt begins to eat at you almost immediatley.")
        End If
        prisoners = prisoners + 1
        Lab()
    End Sub
    Public Sub Lab()
        choice = InputBox("With the lab clear, you look around more carefully" & vbCrLf & "1. Look around the lab benches" & vbCrLf & "2. Return to the Library" & vbCrLf & "3. Head through the next door")
        If (choice = 1) Then
            MsgBox("You search the lab benches but the only thing you find thats not bolted down is a tiny needle.")
            needle = True
            Lab()
        ElseIf (choice = 2) Then
            PastLock()
        ElseIf (choice = 3) Then
            guardRoom()
        End If
    End Sub
    Public Sub guardRoom()
        MsgBox("You peep through the ajar door and see 2 guards sitting in a room with a couch, a lamp and small desk.")
        choice = InputBox("Would you like to:" & vbCrLf & "1. Attempt to sneak through the room" & vbCrLf & "2. Attempt to distract the guards" & vbCrLf & "3. Return to the lab")
        If (choice = 1) Then
            noise = noise + 1
            If (noise > 1) Then
                MsgBox("The guards see you trying to sneak through the room and catch you, returning you to your cell. You Lose!")
                End
            ElseIf (noise <= 1) Then
                MsgBox("You are barely able to get through the room without the guards noticing, but you do it.")
                Storage()
            End If
        End If
        If (choice = 2) Then
            If (book = True) Then
                MsgBox("You throw the hackey sack at the lamp, knocking it over and smashing it. While the guards are looking at the lamp, you run through the room.")
                Storage()
            ElseIf (book = False) Then
                MsgBox("You have nothing to distract the guards with. You return to the lab.")
                Lab()
            End If
        End If
        If (choice = 3) Then
            Lab()
        End If
    End Sub
    Public Sub Storage()
        MsgBox("You enter the next room and immediatley see a guard standing with his back facing you. The only other thing in the room is a wastebasket, full of paper, sitting right next to your leg. You have to think fast!")
        choice = InputBox("1. Attempt to sneak past the guard" & vbCrLf & "2. Attempt to distract the guard.")
        If (choice = 1) Then
            noise = noise + 1
            If (noise > 1) Then
                MsgBox("As you try to sneak behind the guard, he turns around spotting you instantly. 'Hey!' he calls, 'You're coming with me' You Lose!")
                End
            ElseIf (noise <= 1) Then
                MsgBox("You sprint behind the guard and burst through the next door.")
                Exits()
            End If
        End If
        If (choice = 2) Then
            If (book = True) Then
                MsgBox("You use the lighter to light the paper in the basket aflame. As smoke engulfs the room, you sneak in behind the guard, who is now trying to figure out the source of the fire.")
                Exits()
            ElseIf (book = False) Then
                MsgBox("You have nothing to distract the guard with.")
                Storage()
            End If
        End If
    End Sub
    Public Sub Exits()
        Dim exiter As String
        exiter = InputBox("You burst through the door and end up face to face with a guard. 'Whats's the password?' he asks, unaware that you are escaping")
        If (exiter = "TO BE DECIDED") Or (exiter = "to be decided") Then
            MsgBox("YOU ESCAPED!!!!")
        ElseIf (exiter <> "TO BE DECIDED") Or (exiter <> "to be decided") Then
            MsgBox("You stammer, unsure of the password. 'Ummmmm, " & exiter & "? 'The guard suddenly realizes who you are and grabs you. You Lose!")
            End
        End If
    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'Bolded this to make sure you know where program starts just in case you forget. This is the main so it starts here.
        'the key variable will be used to decide if you attain the key or not
        Dim key As Integer
        MsgBox("You wake up from a long sleep and realize you are imprisoned in a government testing facility. Next to your cell door stands a guard. You slowly stand up and call over to the man.")
        MsgBox("'Ah, you're awake. How do you feel?' asks the guard.")
            choice = InputBox("1. I'm feeling fine. " & vbCrLf & "2. What the hell is this place??")
            If (choice = 2) Then
                MsgBox("'Woah! Still a little aggresive huh. I guess you're not ready to cooperate.' The guard leaves the area.")
                key = 1
                NoKey()
            ElseIf (choice = 1) Then
                MsgBox("'That's great to hear. The scientists always prefer to test on calm subjects.' As the guard says this you see a key dangling from his waist.")
                choice = InputBox("1. Wh-what type of testing?" & vbCrLf & "2. What is that bird doing in here??!?!?")
                If (choice = 2) Then
                    Keys()
                Else
                    MsgBox("'I would tell you, but I think it would rile you up. It's best to not know going into it. I'll be back soon.' The guard leaves the area.")
                    NoKey()
                End If
            End If

    End Sub
End Class


