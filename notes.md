# Challenge 30
1. Erzeuge eine Ebene (Plane) in der Szene.
2. Suche ein Bild im Internet, welches du als Textur auf die Kugel packen willst.

   - Wie bekommst du die Textur zunächst ins Projekt und dann auf die Kugel?
     - `Rechtsklick -> Assets -> Import New Asset... dann auf Kugel ziehen oder im Inspector auf Albedo ziehen`
   - Wo kannst du einstellen, wie häufig das Bild auf die Ebene gebracht wird (Anzahl "Kacheln")?
     - `Im Inspector unter Tiling`
   - Wo kannst du ein Offset einstellen?
     - `Im Inspector unter Offset`
   - Wie kannst du einstellen, dass die Textur beim Wiederholen gespiegelt wird um Brüche zu vermeiden?
     - `Im Inspector bei der Textur unter Wrap Mode -> Mirror oder Tiling auf negative Werte setzen`

3. optional: Erzeuge eine zweite Ebene und lass auf dieser ein Video ablaufen.
   - Wie bekommst du das Video auf die Ebene?
   - Wo kannst du Einstellungen vornehmen: Lautstärke, Loop, etc.

4. Optional: Suche eine Normal Map mit dazugehöriger Albedo (Diffuse Map) im Internet und erzeuge ein Material mit ihnen. Lege das Material auf ein Objekt. Ein guter Suchbegriff ist "3D Texture".

# Challenge 31
## Vorbereitung

- Mach dich mit der Dokumentation des Packages AI Navigation vertraut. Lies insbesondere den Abschnitt Navigation  System in Unity mit allen Unterabschnitten.
- Erkläre deiner Teampartnerin wozu ein NavMesh dient und was ein Agent ist.
    - `Ein NavMesh (Navigation Mesh) ist in der Welt der Computerspiele und der 3D-Simulationen eine Struktur, die dazu dient, die Navigation von virtuellen Agenten in einer Umgebung zu erleichtern. Es ist im Wesentlichen eine vereinfachte Darstellung der Spielwelt, die den Weg oder die Bereiche angibt, die von den Agenten durchlaufen werden können. Ein NavMesh hilft den Agenten, intelligente Entscheidungen darüber zu treffen, wie sie sich in der Umgebung bewegen sollen, und ermöglicht es ihnen, komplexe Hindernisse zu umgehen.`
    - `Ein Agent ist in diesem Kontext eine virtuelle Entität oder ein Steuerungselement, das innerhalb der simulierten Umgebung agiert. Agenten können verschiedene Formen haben, von Charakteren in einem Spiel bis zu autonomen Robotern in einer virtuellen Welt. Diese Agenten interagieren mit ihrer Umgebung, treffen Entscheidungen basierend auf vordefinierten Regeln oder Algorithmen und bewegen sich entsprechend auf dem NavMesh.`

## Samples

- Erstelle ein neues Projekt und installiere das Package AI Navigation.
  - `Window -> Package Manager -> AI Navigation -> Install`
- Installiere aus dem Package die Samples
  - `Window -> Package Manager -> AI Navigation -> Install Samples`
- Probiere alle 8 in den Samples enthaltenen Szenen aus.

## Aufgaben

- Erstelle eine Ebene und platziere einige Objekte (Würfel, Kugeln, etc.) als Hindernisse darauf.
- Folge nun den Anweisungen in den folgenden Dokumentationen um ein NPC zu erstellen, welcher sich durch die Szene bewegt:
  - Create a NavMesh
    - `Window -> AI -> Navigation -> Bake`
  - Create a NavMesh Agent
    - `GameObject -> AI -> NavMesh Agent`
- Das Ziel soll durch ein weiteres Objekt dargestellt werden, welches ihr irgendwo in der Szene platziert. Probiert verschiedene Zielpositionen aus.
  - `GameObject -> 3D Object -> Cube + Skript erstellen`

# Challenge 32
## Teil 1: Git

- Verwendet für diese Challenge  das Projekt aus Assignment 1 - Challenge 4 (mit den Polygon-Starter Assets) oder erstellt ein neues Projekt, in das einige Assets eingefügt werden.
- Füge die .gitignore-Datei im Root-Verzeichnis des Projekts hinzu.
  - Hinweis: Die Datei muss den Namen .gitignore haben. Der Dateiname beginnt mit einem Punkt und hat keine Endung.

- Einstellungen in der Unity IDE in den Project Settings:
  - Stelle unter Version Control sicher, das der Mode auf Visible Meta Files  gesetzt ist.
  - Unter Editor soll der Asset Serialization Mode auf Force Text stehen.


- Erstelle nun auf https://gitlab.iue.fh-kiel.de ein Repository in deinem Namespace (ohne README.md).
- Folge den Schritten auf Gitlab, 'Push an existing Folder' um das bereits vorhandende Projekt auf Gitlab zu pushen.


- Schaue dir auf der GitLab-Seite deines Repositories Project -> Settings -> Usage Quotas an
  - `Repository Size: 3.2 MiB, alles sonst 0B`
- Clone das Projekt erneut auf deinen Rechner.
  - `git clone https://gitlab.iue.fh-kiel.de/soeren.zacharias/avr_assignment5.git`
- Wie ist der Größenunterschied zwischen dem initialen Projekt und dem frisch ge-cloned Projekt.
  - `229 MB zu 13,4 MB`
- Welche Unterschiede sind im Projekt erkennbar?
  - `Es fehlen folgende Ordner: ".idea, Library, Logs, Temp, UserSettings" sowie die Datein: "Assignment5_32.sln und Assembly-CSharp.csproj"`

## Abschließende Fragen:

- Welche Dateien und Verzeichnisse hast du in der .gitignore-Datei ausgeschlossen?
  - `einige`
- Was passiert, wenn du versuchst, Dateien oder Verzeichnisse, die in der .gitignore-Datei aufgeführt sind, in das Git-Repository aufzunehmen?
  - `Sie werden nicht hinzugefügt`
- Wie könntest du in Unity überprüfen, ob die .gitignore-Datei effektiv funktioniert?
  - `?`
- Welche Vorteile bietet die Verwendung von .gitignore in Unity?
  - `Man kann Dateien ausschließen, die nicht in das Repository sollen`

## Teil 2: Git LFS
- Diese Challenge dient dazu, ein Projekt mittels Git und dem Git Large File System (LFS) zu verwalten.

- Lies dir den Abschnitt "What is Git LFS?" unter https://www.atlassian.com/git/tutorials/git-lfs#what-is-git-lfs durch und erkläre deiner Teampartnerin warum es eine gute Idee ist, Git LFS für euer Semesterprojekt zu verwenden.
- Installiere ggf. Git LFS
  - Hinweis auf den Laborrechnern ist Git LFS bereits installiert.


- Lösche aus dem Projektverzeichnis den versteckten Order .git (Damit ist das Projekt nicht mehr mit dem aktuellen git Repo verknüpft)
- Lies dir die Beispiel-Anleitung durch.
- Falls nicht mehr vorhanden, füge die .gitignore hinzu.
- Erzeuge eine leere .gitattributes Datei.
- Füge hier den Inhalt ein dieser .gitattributes

- Erzeuge nun ein zweites Projekt auf GitLab und führe die Commands für einen bereits vorhandenen Ordner aus.
- Vergleiche nun die Seiten Project -> Settings -> Usage Quotas der beiden Projekte
  - `Repository Size: 44.1 KiB, LFS 559,5 KiB`

## Abschließende Fragen:

- Wieso ist es notwendig Git LFS vor dem initialen Commit auszuführen?
  - `Weil sonst die Dateien nicht in LFS gespeichert werden`
- Wie unterscheidet sich die Verwendung von Git LFS zu der Verwendung von .gitignore in Bezug auf die Verwaltung von Binärdateien?
  - `Es werden die Binärdateien in LFS gespeichert`
- Was sind die Vorteile von Git LFS für die Verfolgung von großen Binärdateien?
  - `Es werden nur die Änderungen gespeichert`
- Welche Dateitypen eignen sich am besten für die Verwendung von Git LFS in einem Unity-Projekt?
  - `Texturen (png oder jpeg), Modelle (fbx), Videos (mp4), Audio (mp3)`
- Wie könnte sich die Leistung deines Git-Repositories bei der Verwendung von Git LFS im Vergleich zu .gitignore verändern?
  - `Es wird besser, da die Dateien nicht mehr im Repository gespeichert werden -> git Operationen werden schneller`