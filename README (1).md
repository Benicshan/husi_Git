# IPT1 · Lernsession 03 · GitHub-Flow & Markdown

> **Name:** _Benicshan_  
> **Datum:** _08.09.2026_

## Ziel

Ich kann die wichtigsten Begriffe rund um **Git**, **GitHub**, den **GitHub-Flow** und **Markdown** kurz erklären und meinen Lernfortschritt mit einem eigenen README dokumentieren.

> **Hinweis:** Ersetze die Platzhalter `DEINE ANTWORT` durch deine eigenen kurzen Antworten. Committe die ausgefüllte Datei anschliessend mit einer aussagekräftigen Commit-Nachricht.

---

## 1 · Git und GitHub verstehen

### 1. Was ist Git?

**Meine Antwort:** Git ist eine Versionsverwaltung. Speichert und verwaltet Änderungen Projekten.

### 2. Was ist GitHub?

**Meine Antwort:** GitHub ist eine Online Plattform für Git-Repo und Zusammenarbeit.

### 3. Was ist der wichtigste Unterschied zwischen Git und GitHub?

**Meine Antwort:** Git verwaltet Versionen, GitHub stellt Git-Projekte online bereit und ünterstutzt Zusammenarbeit.

### 4. Funktioniert Git auch ohne GitHub?

**Meine Antwort:** Ja, Git kann man vollständig lokal verwendet werden.

### 5. Was ist ein Repository (Repo)?

**Meine Antwort:** Repo ist ein Projekt mit Dateien und seone Versionsgeschichte.

### 6. Was ist der `main`-Branch?

**Meine Antwort:** Der main-Branch ist ein normalerweise der Hauptbestand eines Projekts.

### 7. Was ist Markdown?

**Meine Antwort:** Markdown ist eine einfache Auszeichnungssprache, mit der Test strukturiert und formatiert wird.

### 8. Was bedeutet GitHub-Flavoured Markdown (GFM)?

**Meine Antwort:** GFM ist GitHub erweiterte  Markdown  Variante z.B. mit Tabellen, Task-Listen und weiteren GitHub- Funktionen.

---

## 2 · GitHub-Flow

### 9. Bringe die Schritte in die richtige Reihenfolge

`Commit · Issue · Pull Request · Branch`

**Meine Antwort:** Issue, Branch, Commit, Pull Request 

### 10. Was ist ein Issue?

**Meine Antwort:** Ein Issue dokumentiert eine Aufgabe, Idee, Anforderung oder einen Fehler.

### 11. Was ist ein Branch?

**Meine Antwort:** Branch ist eine eigene Entwickelungslinie bzw. ein Arbeitszweig innerhalb eines Repo.

### 12. Warum arbeitet man für eine Änderung häufig auf einem eigenen Branch?

**Meine Antwort:** Damit die Änderung getrennt vom Hauptstand entwickelt und geprüft werden kann.

### 13. Was ist ein Commit?

**Meine Antwort:** Ein Commit ist ein gespeicherter, nachvollziehbar Versionsbestand vor Änderungen. 

### 14. Wozu dient eine Commit-Nachricht?

**Meine Antwort:** Sie beschreibt kurz und verständlich, was mit diesen Commit geändert wurde.

### 15. Was ist ein Pull Request?

**Meine Antwort:** Ist die Anfrage, Änderungen eines Branches zu prüffen und in einen Ziel-Branch zu übernehmen.

### 16. Was bedeutet Review?

**Meine Antwort:** Heisst Änderungen geprüft und bei Bedarf kommentiert oder verbessert werden.

### 17. Was bedeutet Merge?

**Meine Antwort:** Bedeutet, Änderungen aus verschiedene Branches Zusammenführen.

### 18. Wann sollte ein Pull Request gemergt werden?

**Meine Antwort:** Wenn die Änderungen fachlich und technisch geprüft akzeptiert werden soll.

---

## 3 · Wichtige Git-Begriffe und Befehle

### 19. Was bedeutet Push?

**Meine Antwort:** Push überträgt lokale Commits zu einem entfernten Repo, z.B. auf GitHub.

### 20. Was bedeutet Pull?

**Meine Antwort:** Pull holt Änderungen aus einem entfernten Repo und integriert sie in den lokalen Stand.

### 21. Was ist der Unterschied zwischen Commit und Push?

**Meine Antwort:** Commit speichert einen Versionsbestand in Git, Push  überträgt Commits zu GitHub bzw. einem Remote-Repo.

### 22. Was ist der Unterschied zwischen Pull und Pull Request?

**Meine Antwort:** Pull holt Änderungen; ein Pull-Request schlägt Änderungen zur Prüfung und Übernahme vor.

### 23. Was bedeutet Clone?

**Meine Antwort:** Clone erstellt eine vollständige lokale Kopie eines Repo.

### 24. Was macht `git status`?

**Meine Antwort:** git status zeigt den aktuellen Zustand der Arbeitsdateien und der Staging Area.

### 25. Was macht `git add`?

**Meine Antwort:** Wählt Änderungen für den nächsten Commit aus und legt sie in die Staging Area.

### 26. Was ist die Staging Area?

**Meine Antwort:** Ist der vorbereitete Bereich für Änderungen, die in den nächsten Commit aufgenommen werden sollen.

### 27. Was macht `git log`?

**Meine Antwort:** git log zeigt die Commit bzw. Versionensgeschichte.

### 28. Was bedeutet Branch wechseln?

**Meine Antwort:** Man wechselt von einer Entwickungslinie auf eine andere z.B. mit git switch.

### 29. Speichert `git add` bereits eine neue Version?

**Meine Antwort:** Nein, git add bereitet Änderungen nur für den nächsten Commit vor.

### 30. Speichert `git push` deine noch nicht committeten Dateiänderungen?

**Meine Antwort:** Nein, push überträgt nur vorhadene Commits, nicht committete Änderungen bleiben lokal.

---

## 4 · GitHub-Flow praktisch erklären

### 31. Erkläre den GitHub-Flow in einem kurzen Satz.

**Meine Antwort:** Eine Aufgabe wird als Issue festgehalten, auf einen Branch bearbeitet,  in Commits gespeichert und über einen Pull-Request geprüft und anschliessend geprüft.

### 32. Ordne die Begriffe zu

| Bedeutung | Git-/GitHub-Begriff |
|---|---|
| Aufgabe | Issue |
| Arbeitszweig | Branch |
| Speicherpunkt | Commit |
| Änderungsantrag | Pull Request |
| Zusammenführen | Merge |

### 33. Welche Richtung beschreibt Push?

**Meine Antwort:** Von eigenen/lokalen Repo zum Remote- Repo bzw. GitHub.

### 34. Welche Richtung beschreibt Pull?

**Meine Antwort:** Vom Remote-Repo bzw. GitHub zum eigenen lokalen Repo.

### 35. Warum sind mehrere sinnvolle Commits oft besser als ein einziger riesiger Commit?

**Meine Antwort:** Weil Änderungen dadurch nachvollzeihbarer profitbarer und ebi Bedarf leichter rückgängig zu machen sind.

### 36. Nenne ein Beispiel für eine gute Commit-Nachricht.

```text
DEINE COMMIT-NACHRICHT: Beispiel README um erster IPT1-Lernnachweis ergänzt.
```

### 37. Warum ist die Commit-Nachricht `update` wenig hilfreich?

**Meine Antwort:** Weil es nicht beschreibt, was konkret geändert wurde.

---

## 5 · Markdown und README

### 38. Überschrift Ebene 1

Ergänze darunter eine Markdown-Überschrift der Ebene 1:

DEINE ANTWORT

### 39. Ungeordnete Liste

Erstelle eine Liste mit mindestens drei Begriffen aus dieser Lernsession:

DEINE ANTWORT

### 40. Link

Erstelle einen funktionierenden Markdown-Link zu GitHub oder Microsoft Learn:

DEINE ANTWORT

### 41. Bild

Schreibe die Markdown-Syntax für ein Bild mit Alternativtext:

```text
DEINE ANTWORT
```

### 42. Inline-Code

Schreibe `git status` als Inline-Code in einem sinnvollen Satz:

DEINE ANTWORT

### 43. Codeblock

Ergänze mindestens drei Git-Befehle in diesem Codeblock:

```bash
# DEINE BEFEHLE
```

### 44. Was sollte ein gutes Portfolio-README mindestens leisten?

**Meine Antwort:** DEINE ANTWORT

---

## 6 · Mein fachlicher Lernnachweis

### Was habe ich heute über Git und GitHub gelernt?

Git verwaltet Versionsgewalt eines Projekts. GitHub stellt Git-Repo online bereit.

### Was habe ich heute praktisch umgesetzt?

Ich habe mein README mit Markdown struktiert, einen Lernachweis ergänzt.

### Meine konkrete Verbesserung aus dem Selbst- oder Peer-Check

DEINE ANTWORT

### Mein nächster Portfolio-Schritt

DEINE ANTWORT

---

## 7 · Microsoft Learn · Abschlusskontrolle

- [] **Einführung in GitHub**: Übung, Modulbewertung und Zusammenfassung abgeschlossen
- [ ] **Effektive Kommunikation auf GitHub mithilfe von Markdown** abgeschlossen
- [x] Ich habe meinen Lernfortschritt / meine Modulbewertung kontrolliert.

## 8 · Begriffe · deutsche Merkhilfe

Fülle die zweite Spalte mit einer kurzen deutschen Merkhilfe aus.

| Begriff | Deutsche Merkhilfe |
|---|---|
| Issue | Aufgabe/ Ticket  |
| Branch | Zweig  |
| Commit | gespeichter Versionenbestand  |
| Push | Senden/hochladen |
| Pull | holen/ aktualisieren |
| Pull Request | Änderungsanfrag |
| Review | prüfen |
| Merge | zusammenführen  |
| Clone | klonen / kopieren |
| Repository | Projektablage mit Versionsgeschichte |

---

## 9 · Selbstcheck

- [x ] Ich kann **Git** und **GitHub** unterscheiden.
- [x] Ich kann **Issue → Branch → Commit → Pull Request → Merge** erklären.
- [x ] Ich kenne den Unterschied zwischen **Commit** und **Push**.
- [x ] Ich kenne den Unterschied zwischen **Pull** und **Pull Request**.
- [ ] Ich kann Überschriften, Listen, Links, Bilder und Codeblöcke in Markdown verwenden.
- [ ] Mein README wird auf GitHub korrekt gerendert.
- [ ] Ich habe mindestens eine konkrete Verbesserung umgesetzt.
- [ ] Ich habe meine Änderung mit einer aussagekräftigen Commit-Nachricht dokumentiert.

## Meine Commit-Nachricht für diese Abgabe

```text
DEINE COMMIT-NACHRICHT
```
